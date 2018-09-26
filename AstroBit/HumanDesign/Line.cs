using System.Diagnostics;
using AstroBit.AstroMath;

namespace AstroBit.HumanDesign
{
    [DebuggerDisplay("{ToString()}")]
    public class Line
    {
        public Line(int number, double startDegree, double endDegree)
        {
            Number = number.Check(n => n >= 1 && n <= 6);
            StartDegree = startDegree;
            EndDegree = endDegree;
        }

        public int Number { get; }

        public double StartDegree { get; }

        public double EndDegree { get; }

        public override string ToString() =>
            $"{Number} {StartDegree.ToArc().ToZodiacString()} - {EndDegree.ToArc().ToZodiacString()}";
    }
}
