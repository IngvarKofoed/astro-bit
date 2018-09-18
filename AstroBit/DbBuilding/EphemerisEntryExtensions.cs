using System;

namespace AstroBit.DbBuilding
{
    public static class EphemerisEntryExtensions
    {
        public static long ToId(this DateTime dateTime) =>
            (long)dateTime.Hour << 8 + dateTime.Minute;
    }
}
