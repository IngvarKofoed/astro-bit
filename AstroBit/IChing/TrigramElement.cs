namespace AstroBit.IChing
{
    public enum TrigramElement
    {
        Heaven = 1,
        Earth = 2,
        Thunder = 3,
        Water = 4,
        Mountain = 5,
        Wind = 6,
        Fire = 7,
        Swamp = 8
    }

    public static class TrigramElementExtensions
    {
        public static Trigram ToTrigram(this TrigramElement trigramElement) =>
            (Trigram)(int)trigramElement;
    }
}
