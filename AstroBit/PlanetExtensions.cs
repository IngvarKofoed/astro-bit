namespace AstroBit
{
    public static class PlanetExtensions
    {
        public static double GetZodiacStartDegree(this Planet planet) =>
            ZodiacExtensions.GetZodiacLocalStartDegrees(planet.AbsolutePosition);

        public static Zodiac GetZodiac(this Planet planet) =>
            ZodiacExtensions.GetZodiac(planet.AbsolutePosition);
    }
}
