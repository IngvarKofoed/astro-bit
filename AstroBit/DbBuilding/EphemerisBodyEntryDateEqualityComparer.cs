using System.Collections.Generic;

namespace AstroBit.DbBuilding
{
    public class EphemerisBodyEntryDateEqualityComparer : IEqualityComparer<AstroBit.Ephemeris.EphemerisBodyEntry>
    {
        public bool Equals(AstroBit.Ephemeris.EphemerisBodyEntry x, AstroBit.Ephemeris.EphemerisBodyEntry y) =>
            x.Date.Ticks == x.Date.Ticks;

        public int GetHashCode(AstroBit.Ephemeris.EphemerisBodyEntry obj) =>
            obj.Date.Ticks.GetHashCode();
    }
}
