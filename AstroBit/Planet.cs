using AstroBit.AstroMath;

namespace AstroBit
{
    public class Planet
    {
        public Planet(PlanetType type, double absolutePosition, PlanetDirection direction = PlanetDirection.Direct)
        {
            Type = type;
            AbsolutePosition = absolutePosition;
            Direction = direction;
        }

        public PlanetType Type { get; }

        public double AbsolutePosition { get; }

        public PlanetDirection Direction { get; }

        public override string ToString() =>
            Type == PlanetType.Sun
                ? $"{AbsolutePosition.ToArc().ToZodiacString()}{(Direction == PlanetDirection.Direct ? " " : "R")}"
                : $"{AbsolutePosition.ToArc().ToZodiacShortString()}{(Direction == PlanetDirection.Direct ? " " : "R")}";
    }
}
