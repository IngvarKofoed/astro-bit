using System;
using AstroBit.Horizons;

namespace AstroBit.Horizons.DbBuilding
{
    public static class EphemerisDbEntryExtensions
    {
        public static long ToId(this DateTime dateTime) =>
            (long)dateTime.Hour << (8 + dateTime.Minute);

        public static EphemerisEntry ToEphemerisEntry(this EphemerisDbEntry entry) =>
            new EphemerisEntry(
                entry.Date,
                entry.SiderealTime,
                entry.Sun,
                entry.Moon,
                entry.Mercury,
                entry.MercuryRetrograde,
                entry.Venus,
                entry.VenusRetrograde,
                entry.Mars,
                entry.MarsRetrograde,
                entry.Jupiter,
                entry.JupiterRetrograde,
                entry.Saturn,
                entry.SaturnRetrograde,
                entry.Uranus,
                entry.UranusRetrograde,
                entry.Neptune,
                entry.NeptuneRetrograde,
                entry.Pluto,
                entry.PlutoRetrograde,
                entry.Chiron,
                entry.NorthNode,
                entry.BlackMoonLilith);
    }
}
