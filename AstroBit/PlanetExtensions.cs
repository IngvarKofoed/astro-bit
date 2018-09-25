namespace AstroBit
{
    public static class PlanetExtensions
    {
        public static Zodiac GetZodiac(this Planet planet) =>
            ZodiacExtensions.GetZodiac(planet.AbsolutePosition);

        public static double GetZodiacLocalDegrees(this Planet planet) =>
            ZodiacExtensions.GetZodiacLocalDegrees(planet.AbsolutePosition);

        public static double GetZodiacStartDegree(this Planet planet) =>
            ZodiacExtensions.GetZodiacLocalStartDegrees(planet.AbsolutePosition);
    }
}
