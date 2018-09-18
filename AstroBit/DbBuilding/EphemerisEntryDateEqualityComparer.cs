using System.Collections.Generic;

namespace AstroBit.DbBuilding
{
    public class EphemerisEntryDateEqualityComparer : IEqualityComparer<AstroBit.Ephemeris.EphemerisEntry>
    {
        public bool Equals(AstroBit.Ephemeris.EphemerisEntry x, AstroBit.Ephemeris.EphemerisEntry y) =>
            x.Date.Ticks == x.Date.Ticks;

        public int GetHashCode(AstroBit.Ephemeris.EphemerisEntry obj) =>
            obj.Date.Ticks.GetHashCode();
    }
}
