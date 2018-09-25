using System;

namespace AstroBit.Horizons
{
    public class EphemerisBodyEntry
    {
        public EphemerisBodyEntry(Body body, DateTime date, double siderealTime, double longitude, double latitude)
        {
            Body = body;
            Date = date;
            SiderealTime = siderealTime;
            Longitude = longitude;
            Latitude = latitude;
        }

        public Body Body { get; }

        public DateTime Date { get; }

        public double SiderealTime { get; }

        public double Longitude { get; }

        public double Latitude { get; }
    }
}
