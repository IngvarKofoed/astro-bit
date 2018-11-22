using System.Collections.Generic;
using System.Linq;

namespace AstroBit.IChing
{
    public class Hexagram
    {
        public Hexagram(
            int number,
            string name,
            Trigram innerTrigram,
            Trigram outerTrigram,
            IEnumerable<HexagramLine> lines)
        {
            Number = number.Check(x => x >= 1 && x <= 64);
            Name = name.NotNull(nameof(name));
            InnerTrigram = innerTrigram;
            OuterTrigram = outerTrigram;
            Lines = lines.Check(x => x.Count() == 6).ToList().AsReadOnly();
        }

        public int Number { get; }

        public string Name { get; }

        public Trigram InnerTrigram { get; }

        public Trigram OuterTrigram { get; }

        public IReadOnlyList<HexagramLine> Lines { get; }

        public override string ToString() =>
            $"{Number} {Name} {InnerTrigram} ({InnerTrigram.ToElement()}) {OuterTrigram} ({OuterTrigram.ToElement()})";
    }
}
