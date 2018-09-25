using System;

namespace AstroBit.EphemerisDBBuilder
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
            Sun = sun;
            Moon = moon;
            Mercury = mercury;
            Venus = venus;
            Mars = mars;
            Jupiter = jupiter;
            Saturn = saturn;
            Uranus = uranus;
            Neptune = neptune;
            Pluto = pluto;
            TrueNode = trueNode;
            MeanNone = meanNode;
            BlackMoonLilith = blackmoonLilith;
            Chiron = chiron;
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

        public override string ToString() =>
            $"{Date.ToString("yyyy-MM-dd")} {Sun} {Moon} {Mercury} {Venus} {Mars} {Jupiter} {Saturn} {Uranus} {Neptune} {Pluto} {TrueNode} {MeanNone} {BlackMoonLilith} {Chiron}";
    }
}
