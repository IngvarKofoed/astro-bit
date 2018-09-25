using System.Collections.Generic;

namespace AstroBit.Horizons
{
    public interface IEphemerisProvider
    {
        IEnumerable<EphemerisBodyEntry> GetEntires(Body body, ObserverPosition observerPosition, TimeInterval timeInterval);
    }
}
