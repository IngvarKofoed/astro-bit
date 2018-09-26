using AstroBit.AstroMath;

namespace AstroBit.HumanDesign
{
    public static class GateExtensions
    {
        public static bool IsInGate(this Gate gate, double absoluteDegrees) =>
            AMath.IsInCircleRange(gate.Lines[0].StartDegree, gate.Lines[5].EndDegree, absoluteDegrees);
    }
}
