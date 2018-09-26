namespace AstroBit.HumanDesign
{
    public class DefinedGate
    {
        public DefinedGate(int gateNumber, int lineNumber)
        {
            GateNumber = gateNumber;
            LineNumber = lineNumber;
        }

        public int GateNumber { get; }

        public int LineNumber { get; }

        public override string ToString() =>
            $"{GateNumber}.{LineNumber}";
    }
}
