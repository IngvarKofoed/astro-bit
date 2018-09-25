using System;
using AstroBit.AstroMath;
using AstroBit.Database;

namespace AstroBit
{
    public class Ephemeris
    {
        public EphemerisEntry Get(DateTime date)
        {
            var utcDate = date.ToUniversalTime();
            var dateToFind = new DateTime(utcDate.Year, utcDate.Month, utcDate.Day, 0, 0, 0, DateTimeKind.Utc);
            var id1 = dateToFind.Ticks;
            var id2 = (dateToFind + TimeSpan.FromDays(1)).Ticks;

            using (var context = new EphemerisContext())
            {
                var entry1 = context.Ephemeris.Find(id1);
                var entry2 = context.Ephemeris.Find(id2);

                var diff = date - dateToFind;
                var fraction = diff.TotalSeconds / (24.0 * 60.0 * 60.0);

                var entry = new EfEphemerisEntry
                {
                    Id = 0,
                    Date = date,
                    SiderealTime = AMath.Interpolate(entry1.SiderealTime, entry2.SiderealTime, fraction),
                    Sun = AMath.Interpolate(entry1.Sun, entry2.Sun, fraction),
                    Moon = AMath.Interpolate(entry1.Moon, entry2.Moon, fraction),
                    Mercury = AMath.Interpolate(entry1.Mercury, entry2.Mercury, fraction, entry1.MercuryRetrograde),
                    MercuryRetrograde = entry1.MercuryRetrograde,
                    Venus = AMath.Interpolate(entry1.Venus, entry2.Venus, fraction, entry1.VenusRetrograde),
                    VenusRetrograde = entry1.VenusRetrograde,
                    Mars = AMath.Interpolate(entry1.Mars, entry2.Mars, fraction, entry1.MarsRetrograde),
                    MarsRetrograde = entry1.MarsRetrograde,
                    Jupiter = AMath.Interpolate(entry1.Jupiter, entry2.Jupiter, fraction, entry1.JupiterRetrograde),
                    JupiterRetrograde = entry1.JupiterRetrograde,
                    Saturn = AMath.Interpolate(entry1.Saturn, entry2.Saturn, fraction, entry1.SaturnRetrograde),
                    SaturnRetrograde = entry1.SaturnRetrograde,
                    Uranus = AMath.Interpolate(entry1.Uranus, entry2.Uranus, fraction, entry1.UranusRetrograde),
                    UranusRetrograde = entry1.UranusRetrograde,
                    Neptune = AMath.Interpolate(entry1.Neptune, entry2.Neptune, fraction, entry1.NeptuneRetrograde),
                    NeptuneRetrograde = entry1.NeptuneRetrograde,
                    Pluto = AMath.Interpolate(entry1.Pluto, entry2.Pluto, fraction, entry1.PlutoRetrograde),
                    PlutoRetrograde = entry1.PlutoRetrograde,
                    TrueNode = AMath.Interpolate(entry1.TrueNode, entry2.TrueNode, fraction, entry1.TrueNodeRetrograde),
                    TrueNodeRetrograde = entry1.TrueNodeRetrograde,
                    MeanNode = AMath.Interpolate(entry1.MeanNode, entry2.MeanNode, fraction, entry1.MeanNodeRetrograde),
                    MeanNodeRetrograde = entry1.MeanNodeRetrograde,
                    BlackMoonLilith = AMath.Interpolate(entry1.BlackMoonLilith, entry2.BlackMoonLilith, fraction, entry1.BlackMoonLilithRetrograde),
                    BlackMoonLilithRetrograde = entry1.BlackMoonLilithRetrograde,
                    Chiron = AMath.Interpolate(entry1.Chiron, entry2.Chiron, fraction, entry1.ChironRetrograde),
                    ChironRetrograde = entry1.ChironRetrograde
                };

                return entry.ToEntry();
            }
        }
    }
}
