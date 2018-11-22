namespace AstroBit.IChing
{
    public enum Trigram
    {
        Force = 1,      // Heaven
        Field = 2,      // Earth
        Shake = 3,      // Thunder
        Gorge = 4,      // Water
        Bound = 5,      // Mountain
        Ground = 6,     // Wind
        Radiance = 7,   // Fire
        Open = 8        // Swamp
    }

    public static class TrigramExtensions
    {
        public static TrigramElement ToElement(this Trigram trigram) =>
            (TrigramElement)(int)trigram;
    }
}
