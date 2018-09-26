using AstroBit.AstroMath;

namespace AstroBit.HumanDesign
{
    public static class LineExtensions
    {
        public static bool IsInLine(this Line line, double absoluteDegrees) =>
            AMath.IsInCircleRange(line.StartDegree, line.EndDegree, absoluteDegrees);
    }
}
