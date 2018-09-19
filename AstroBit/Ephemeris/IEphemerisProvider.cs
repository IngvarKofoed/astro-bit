using System.Collections.Generic;

namespace AstroBit.Ephemeris
{
    public interface IEphemerisProvider
    {
        IEnumerable<EphemerisBodyEntry> GetEntires(Body body, ObserverPosition observerPosition, TimeInterval timeInterval);
    }
}
