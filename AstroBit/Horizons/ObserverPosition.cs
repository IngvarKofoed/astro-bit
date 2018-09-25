namespace AstroBit.Horizons
{
    public struct ObserverPosition
    {
        public ObserverPosition(double longitude, double latitude, double altitude = 0.0)
        {
            Longitude = longitude;
            Latitude = latitude;
            Altitude = altitude;
        }

        public double Longitude { get; }

        public double Latitude { get; }

        public double Altitude { get; }
    }
}
