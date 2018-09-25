using System;
using System.Collections.Generic;
using AstroBit.Horizons.Providers.Horizons.Telnet;

namespace AstroBit.Horizons.Providers.Horizons
{
    public class HorizonsEphemerisProvider : IEphemerisProvider
    {
        public IEnumerable<EphemerisBodyEntry> GetEntires(Body body, ObserverPosition observerPosition, TimeInterval timeInterval)
        {
            var client = new HorizonsTelnetClient();

            var entries = client.GetEntires(
                ToBodyId(body),
                observerPosition.Longitude,
                observerPosition.Latitude,
                observerPosition.Altitude,
                timeInterval.StartTime,
                timeInterval.EndTime,
                timeInterval.IntervalSize,
                ToIntervalUnit(timeInterval.IntervalUnit));

            foreach (var entry in entries)
            {
                yield return new EphemerisBodyEntry(body, entry.Date, entry.SiderealTime, entry.Longitude, entry.Latitude);
            }
        }

        private static BodyId ToBodyId(Body body)
        {
            switch (body)
            {
                case Body.Sun:
                    return BodyId.Sun;

                case Body.Moon:
                    return BodyId.Moon;

                case Body.Mercury:
                    return BodyId.Mercury;

                case Body.Venus:
                    return BodyId.Venus;

                case Body.Mars:
                    return BodyId.Mars;

                case Body.Jupiter:
                    return BodyId.Jupiter;

                case Body.Saturn:
                    return BodyId.Saturn;

                case Body.Uranus:
                    return BodyId.Uranus;

                case Body.Neptune:
                    return BodyId.Neptune;

                case Body.Pluto:
                    return BodyId.Pluto;

                case Body.Chiron:
                    return BodyId.Chiron;

                default:
                    throw new NotImplementedException();
            }
        }

        private static Telnet.IntervalUnit ToIntervalUnit(IntervalUnit intervalUnit)
        {
            switch (intervalUnit)
            {
                case IntervalUnit.Minutes:
                    return Telnet.IntervalUnit.Minutes;

                case IntervalUnit.Hours:
                    return Telnet.IntervalUnit.Hours;

                case IntervalUnit.Days:
                    return Telnet.IntervalUnit.Days;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
