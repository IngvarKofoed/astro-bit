using System;
using System.Collections.Generic;
using System.Text;

namespace AstroBit.Ephemeris.Providers.Horizons
{
    public class HorizonsEphemerisProvider : IEphemerisProvider
    {
        public IEnumerable<EphemerisEntry> GetEntires(Body body, ObserverPosition observerPosition, TimeInterval timeInterval)
        {
            throw new NotImplementedException();
        }
    }
}
