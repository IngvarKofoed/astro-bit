using System;
using System.Collections.Generic;
using System.Linq;
using AstroBit.Ephemeris;
using AstroBit.Ephemeris.Providers.Horizons;

namespace AstroBit.DbBuilding
{
    public abstract class EphemerisFetcher
    {
        private static readonly Body[] bodies = new Body[]
        {
            Body.Sun,
            Body.Mercury,
            Body.Venus,
            Body.Moon,
            Body.Mars,
            Body.Jupiter,
            Body.Saturn,
            Body.Uranus,
            Body.Neptune,
            Body.Pluto,
            Body.Chiron
        };

        public void FetchYear(int year)
        {
            IEphemerisProvider provider = new HorizonsEphemerisProvider();

            foreach (var body in bodies)
            {
                Console.WriteLine($"Fetching ephemeris data for {body} in the year {year}...");

                var entries = provider
                    .GetEntires(body, new ObserverPosition(0, 0, 0), new TimeInterval(new DateTime(year, 1, 1, 0, 0, 0), new DateTime(year + 1, 1, 1, 0, 0, 0), this.IntervalSize, this.IntervalUnit))
                    .Distinct(new EphemerisEntryDateEqualityComparer())
                    .Where(x => x.Date.Year == year)
                    .OrderBy(x => x.Date)
                    .ToList();

                Console.WriteLine($"Persisting ephemeris data for {body} in the year {year}...");

                OnNewEntries(entries, body, year);
            }
        }

        public void FetchRange(int startYear, int endYear)
        {
            for (int year = startYear; year <= endYear; year++)
            {
                FetchYear(year);
            }
        }

        public int IntervalSize { get; set; } = 1;

        public AstroBit.Ephemeris.IntervalUnit IntervalUnit { get; set; } = AstroBit.Ephemeris.IntervalUnit.Hours;

        protected abstract void OnNewEntries(List<AstroBit.Ephemeris.EphemerisEntry> entires, Body body, int year);
    }
}
