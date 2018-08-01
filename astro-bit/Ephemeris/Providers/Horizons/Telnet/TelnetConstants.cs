namespace AstroBit.Ephemeris.Providers.Horizons.Telnet
{
    internal static class TelnetConstants
    {
        public const string NewLine = "\r\n";
        public const string StartTerminationString = "Horizons> ";
        public const string SelectionTerminationString = "] : ";
        public const string BodySelectionTerminationString = ">: ";        
        public const string GeodeticCoordinatesSelectionTerminationString = "} : ";
        public const string TableTerminationString = "? : ";
        public const string TableStartString = "$$SOE";
        public const string TableEndString = "$$EOE";
    }
}
