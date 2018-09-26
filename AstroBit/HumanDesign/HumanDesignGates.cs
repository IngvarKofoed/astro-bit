using System.Collections.Generic;
using System.Linq;
using AstroBit.Database;

namespace AstroBit.HumanDesign
{
    public class HumanDesignGates
    {
        private readonly List<Gate> gates;

        public HumanDesignGates()
        {
            using (var context = new HumanDesignDbContext())
            {
                gates = context
                    .Gates
                    .GroupBy(x => x.GateNumber)
                    .Select(x => x.ToGate())
                    .ToList();
            }
        }

        public Gate GetGateByNumber(int gateNumber) =>
            gates.Single(x => x.Number == gateNumber);

        public Gate GetGateByDegree(double absoluteDegrees) =>
            gates.First(x => x.IsInGate(absoluteDegrees));

        public DefinedGate GetDefinedGate(double absoluteDegress) =>
            gates
                .First(x => x.IsInGate(absoluteDegress))
                .Apply(x => (GateNumber: x.Number, LineNumber: x.Lines.First(y => y.IsInLine(absoluteDegress)).Number))
                .Apply(x => new DefinedGate(x.GateNumber, x.LineNumber));        
    }
}
