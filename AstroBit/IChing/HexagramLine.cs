namespace AstroBit.IChing
{
    public class HexagramLine
    {
        public HexagramLine(int number, double startDegree, double endDegree)
        {
            Number = number.Check(n => n >= 1 && n <= 6);
            StartDegree = startDegree.Check(x => x >= 0.0 && x <= 360.0);
            EndDegree = endDegree.Check(x => x >= 0.0 && x <= 360.0);
        }

        public int Number { get; }

        public double StartDegree { get; }

        public double EndDegree { get; }

        public override string ToString() =>
            $"{Number} {StartDegree} - {EndDegree}";
    }
}
