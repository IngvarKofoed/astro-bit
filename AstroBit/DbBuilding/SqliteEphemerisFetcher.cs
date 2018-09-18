using AstroBit.Ephemeris;
using System.Collections.Generic;
using System.Linq;

namespace AstroBit.DbBuilding
{
    public class SqliteEphemerisFetcher : EphemerisFetcher
    {
        protected override void OnNewEntries(List<AstroBit.Ephemeris.EphemerisEntry> entires, Body body, int year)
        {
            using (var context = new EphemerisDbContext())
            {
                foreach (var entry in entires)
                {
                    var existingEntry = context.Ephemeris.Where(x => x.Id == entry.Date.Ticks).SingleOrDefault();
                    if (existingEntry == null)
                    {
                        var newEntry = new EphemerisEntry
                        {
                            Id = entry.Date.Ticks,
                            Date = entry.Date,
                            SiderealTime = entry.SiderealTime
                        };
                        AssignValue(newEntry, body, entry.Longitude);

                        context.Ephemeris.Add(newEntry);

                        // Console.WriteLine($"ADDED: {body} {entry.Date}: {entry.Longitude} - {entry.Longitude.ToArc().ToZodiacSignTimeString()}");
                    }
                    else
                    {
                        AssignValue(existingEntry, body, entry.Longitude);
                        // Console.WriteLine($"UPDATED: {body} {entry.Date}: {entry.Longitude} - {entry.Longitude.ToArc().ToZodiacSignTimeString()}");
                    }
                }

                context.SaveChanges();
            }
        }

        private void AssignValue(EphemerisEntry entry, Body body, double value)
        {
            switch (body)
            {
                case Body.Sun:
                    entry.Sun = value;
                    break;

                case Body.Moon:
                    entry.Moon = value;
                    break;

                case Body.Mercury:
                    entry.Mercury = value;
                    break;

                case Body.Venus:
                    entry.Venus = value;
                    break;

                case Body.Mars:
                    entry.Mars = value;
                    break;

                case Body.Jupiter:
                    entry.Jupiter = value;
                    break;

                case Body.Saturn:
                    entry.Saturn = value;
                    break;

                case Body.Uranus:
                    entry.Uranus = value;
                    break;

                case Body.Neptune:
                    entry.Neptune = value;
                    break;

                case Body.Pluto:
                    entry.Pluto = value;
                    break;

                case Body.Chiron:
                    entry.Chiron = value;
                    break;
            }
        }
    }
}
