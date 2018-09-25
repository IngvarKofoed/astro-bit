namespace AstroBit.EphemerisDBBuilder
{
    public static class PlanetExtensions
    {
        public static double GetZodiacStartDegree(this Planet planet)  =>
            ((int)planet.AbsolutePosition / 30) * 30;
    }
}
