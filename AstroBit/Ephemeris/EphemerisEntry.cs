using System;

namespace AstroBit.Ephemeris
{
    public class EphemerisEntry
    {
        public EphemerisEntry(
            DateTime date,
            double siderealTime,
            double sun,
            double moon,
            double mercury,
            bool mercuryRetrograde,
            double venus,
            bool venusRetrograde,
            double mars,
            bool marsRetrograde,
            double jupiter,
            bool jupiterRetrograde,
            double saturn,
            bool saturnRetrograde,
            double uranus,
            bool uranusRetrograde,
            double neptune,
            bool neptuneRetrograde,
            double pluto,
            bool plutoRetrograde,
            double chiron,
            double northNode,
            double blackMoonLilith)
        {
            Date = date;
            SiderealTime = siderealTime;
            Sun = sun;
            Moon = moon;
            Mercury = mercury;
            MercuryRetrograde = mercuryRetrograde;
            Venus = venus;
            VenusRetrograde = venusRetrograde;
            Mars = mars;
            MarsRetrograde = marsRetrograde;
            Jupiter = jupiter;
            JupiterRetrograde = jupiterRetrograde;
            Saturn = saturn;
            SaturnRetrograde = saturnRetrograde;
            Uranus = uranus;
            UranusRetrograde = uranusRetrograde;
            Neptune = neptune;
            NeptuneRetrograde = neptuneRetrograde;
            Pluto = pluto;
            PlutoRetrograde = plutoRetrograde;
            Chiron = chiron;
            NorthNode = northNode;
            BlackMoonLilith = blackMoonLilith;
        }

        public DateTime Date { get; }

        public double SiderealTime { get; }

        public double Sun { get; }

        public double Moon { get; }

        public double Mercury { get; }

        public bool MercuryRetrograde { get; }

        public double Venus { get; }

        public bool VenusRetrograde { get; }

        public double Mars { get; }

        public bool MarsRetrograde { get; }

        public double Jupiter { get; }

        public bool JupiterRetrograde { get; }

        public double Saturn { get; }

        public bool SaturnRetrograde { get; }

        public double Uranus { get; }

        public bool UranusRetrograde { get; }

        public double Neptune { get; }

        public bool NeptuneRetrograde { get; }

        public double Pluto { get; }

        public bool PlutoRetrograde { get; }

        public double Chiron { get; }

        public double NorthNode { get; }

        public double BlackMoonLilith { get; }
    }
}
