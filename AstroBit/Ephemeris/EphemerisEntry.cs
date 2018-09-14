using System;

namespace AstroBit.Ephemeris
{
    public class EphemerisEntry
    {
        public EphemerisEntry(DateTime date, double siderealTime, double longitude, double latitude)
        {
            Date = date;
            SiderealTime = siderealTime;
            Longitude = longitude;
            Latitude = latitude;
        }

        public DateTime Date { get; }

        public double SiderealTime { get; }

        public double Longitude { get; }

        public double Latitude { get; }
    }
}
