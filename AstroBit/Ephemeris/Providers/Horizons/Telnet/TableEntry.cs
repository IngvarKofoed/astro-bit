using System;
using System.Diagnostics;

namespace AstroBit.Ephemeris.Providers.Horizons.Telnet
{
    [DebuggerDisplay("{ToString()}")]
    public struct TableEntry
    {
        public TableEntry(DateTime date, double longitude, double latitude, bool observerDayligt)
        {
            Date = date;
            Longitude = longitude;
            Latitude = latitude;
            ObserverDaylight = observerDayligt;
        }

        public DateTime Date { get; }

        public double Longitude { get; }

        public double Latitude { get; }

        public bool ObserverDaylight { get; }

        public override string ToString() =>
            $"{Date.ToString("yyyy-MM-dd HH:mm")} {string.Format("{0,12:###.0000000}", Longitude)}, {string.Format("{0,12:###.0000000}", Latitude)} {ObserverDaylight}";
    }
}
