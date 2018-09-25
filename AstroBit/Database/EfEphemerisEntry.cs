using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AstroBit.Database
{
    [Table("ephemeris")]
    public class EfEphemerisEntry
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public double SiderealTime { get; set; }

        public double Sun { get; set; }

        public double Moon { get; set; }

        public double Mercury { get; set; }

        public bool MercuryRetrograde { get; set; }

        public double Venus { get; set; }

        public bool VenusRetrograde { get; set; }

        public double Mars { get; set; }

        public bool MarsRetrograde { get; set; }

        public double Jupiter { get; set; }

        public bool JupiterRetrograde { get; set; }

        public double Saturn { get; set; }

        public bool SaturnRetrograde { get; set; }

        public double Uranus { get; set; }

        public bool UranusRetrograde { get; set; }

        public double Neptune { get; set; }

        public bool NeptuneRetrograde { get; set; }

        public double Pluto { get; set; }

        public bool PlutoRetrograde { get; set; }

        public double TrueNode { get; set; }

        public bool TrueNodeRetrograde { get; set; }

        public double MeanNode { get; set; }

        public bool MeanNodeRetrograde { get; set; }

        public double BlackMoonLilith { get; set; }

        public bool BlackMoonLilithRetrograde { get; set; }

        public double Chiron { get; set; }

        public bool ChironRetrograde { get; set; }
    }
}
