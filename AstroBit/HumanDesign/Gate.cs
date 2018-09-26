using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AstroBit.AstroMath;

namespace AstroBit.HumanDesign
{
    [DebuggerDisplay("{ToString()}")]
    public class Gate : IEquatable<Gate>
    {
        public Gate(int number, IEnumerable<Line> lines)
        {
            Number = number.Check(n => n >= 1 && n <= 64);
            Lines = lines
                .NotNull()
                .ToList()
                .Check(x => x.Count == 6)
                .Check(ValidateLines, "Lines does not come in order")
                .AsReadOnly();
        }

        public int Number { get; }

        public IReadOnlyList<Line> Lines { get; }

        public override string ToString() =>
            $"{Number}: {Lines[0].StartDegree.ToArc().ToZodiacString()} - {Lines[5].EndDegree.ToArc().ToZodiacString()}";

        public bool Equals(Gate other) =>
            other == null ? false : Number == other.Number;

        public override bool Equals(object obj) =>
            Equals(obj as Gate);

        public override int GetHashCode() =>
            Number.GetHashCode();

        private static bool ValidateLines(List<Line> lines)
        {
            for (int i = 0; i < 5; i++)
            {
                var diff = lines[i].EndDegree - lines[i + 1].StartDegree;
                if (diff > AMath.Epsilon)
                {
                    return false;
                }
            }

            return true;
        }        
    }
}
