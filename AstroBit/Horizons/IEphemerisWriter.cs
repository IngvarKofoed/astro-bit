using System.Collections.Generic;

namespace AstroBit.Horizons
{
    public interface IEphemerisWriter
    {
        void Write(IEnumerable<EphemerisEntry> ephemerisEntries);
    }
}
