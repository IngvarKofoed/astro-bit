using System.Collections.Generic;

namespace AstroBit.Ephemeris
{
    public interface IEphemerisProvider
    {
        IEnumerable<EphemerisEntry> GetEntires(Body body, ObserverPosition observerPosition, TimeInterval timeInterval);
    }
}
