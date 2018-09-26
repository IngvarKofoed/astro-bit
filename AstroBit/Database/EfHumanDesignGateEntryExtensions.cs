using AstroBit.HumanDesign;
using System.Collections.Generic;
using System.Linq;

namespace AstroBit.Database
{
    public static class EfHumanDesignGateEntryExtensions
    {
        public static Gate ToGate(this IEnumerable<EfHumanDesignGateEntry> gateEntries) =>
            new Gate(
                gateEntries.First().GateNumber,
                gateEntries
                    .Select(x => new Line(x.LineNumber, x.StartDegree, x.EndDegree))
                    .OrderBy(x => x.Number));
    }
}
