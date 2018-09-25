using System.Collections.Generic;

namespace AstroBit.Horizons.DbBuilding
{
    public class EphemerisBodyEntryDateEqualityComparer : IEqualityComparer<AstroBit.Horizons.EphemerisBodyEntry>
    {
        public bool Equals(AstroBit.Horizons.EphemerisBodyEntry x, AstroBit.Horizons.EphemerisBodyEntry y) =>
            x.Date.Ticks == x.Date.Ticks;

        public int GetHashCode(AstroBit.Horizons.EphemerisBodyEntry obj) =>
            obj.Date.Ticks.GetHashCode();
    }
}
