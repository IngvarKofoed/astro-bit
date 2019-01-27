using System;
using System.Collections.Generic;

namespace AstroBit
{
    public class EphemerisEntry
    {
        public EphemerisEntry(
            DateTime date,
            double siderealTime,
            Planet sun,
            Planet moon,
            Planet mercury,
            Planet venus,
            Planet mars,
            Planet jupiter,
            Planet saturn,
            Planet uranus,
            Planet neptune,
            Planet pluto,
            Planet trueNode,
            Planet meanNode,
            Planet blackmoonLilith,
            Planet chiron)
        {
            Date = date;
            SiderealTime = siderealTime;
            Sun = sun.Check(p => p.Type == PlanetType.Sun);
            Moon = moon.Check(p => p.Type == PlanetType.Moon);
            Mercury = mercury.Check(p => p.Type == PlanetType.Mercury);
            Venus = venus.Check(p => p.Type == PlanetType.Venus);
            Mars = mars.Check(p => p.Type == PlanetType.Mars);
            Jupiter = jupiter.Check(p => p.Type == PlanetType.Jupiter);
            Saturn = saturn.Check(p => p.Type == PlanetType.Saturn);
            Uranus = uranus.Check(p => p.Type == PlanetType.Uranus);
            Neptune = neptune.Check(p => p.Type == PlanetType.Neptune);
            Pluto = pluto.Check(p => p.Type == PlanetType.Pluto);
            TrueNode = trueNode.Check(p => p.Type == PlanetType.TrueNode);
            MeanNone = meanNode.Check(p => p.Type == PlanetType.MeanNode);
            BlackMoonLilith = blackmoonLilith.Check(p => p.Type == PlanetType.BlackMoonLilith);
            Chiron = chiron.Check(p => p.Type == PlanetType.Chiron);
        }

        public DateTime Date { get; }

        public double SiderealTime { get; }

        public Planet Sun { get; }

        public Planet Moon { get; }

        public Planet Mercury { get; }

        public Planet Venus { get; }

        public Planet Mars { get; }

        public Planet Jupiter { get; }

        public Planet Saturn { get; }

        public Planet Uranus { get; }

        public Planet Neptune { get; }

        public Planet Pluto { get; }

        public Planet TrueNode { get; }

        public Planet MeanNone { get; }

        public Planet BlackMoonLilith { get; }

        public Planet Chiron { get; }

        public IEnumerable<Planet> AllPlanets
        {
            get
            {
                yield return Sun;
                yield return Moon;
                yield return Mercury;
                yield return Venus;
                yield return Mars;
                yield return Jupiter;
                yield return Saturn;
                yield return Uranus;
                yield return Neptune;
                yield return Pluto;
                yield return TrueNode;
                yield return MeanNone;
                yield return BlackMoonLilith;
                yield return Chiron;
            }
        }

        public override string ToString() =>
            $"{Date.ToString("yyyy-MM-dd")} {Sun} {Moon} {Mercury} {Venus} {Mars} {Jupiter} {Saturn} {Uranus} {Neptune} {Pluto} {TrueNode} {MeanNone} {BlackMoonLilith} {Chiron}";
    }
}
