using System.Collections.Generic;

namespace AstroBit.Ephemeris
{
    public interface IEphemerisWriter
    {
        void Write(IEnumerable<EphemerisEntry> ephemerisEntries);
    }
}
