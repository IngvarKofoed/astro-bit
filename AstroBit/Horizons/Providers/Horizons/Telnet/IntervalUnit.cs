using System;

namespace AstroBit.Horizons.Providers.Horizons.Telnet
{
    public enum IntervalUnit
    {
        Minutes,
        Hours,
        Days,
        Months,
        Years
    }

    internal static class HorizonsTelnetIntervalUnitExtensions
    {
        public static string ToTelnetString(this IntervalUnit unit)
        {
            switch (unit)
            {
                case IntervalUnit.Minutes:
                    return "m";

                case IntervalUnit.Hours:
                    return "h";

                case IntervalUnit.Days:
                    return "d";

                case IntervalUnit.Months:
                    return "mo";

                case IntervalUnit.Years:
                    return "u";

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
