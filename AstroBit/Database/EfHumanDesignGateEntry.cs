using System.ComponentModel.DataAnnotations.Schema;

namespace AstroBit.Database
{
    [Table("Gates")]
    public class EfHumanDesignGateEntry
    {
        public int GateNumber { get; set; }

        public int LineNumber { get; set; }

        public double StartDegree { get; set; }

        public double EndDegree { get; set; }
    }
}
