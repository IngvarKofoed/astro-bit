namespace AstroBit
{
    /// <summary>
    /// Methods regarding Zodiac signs.
    /// </summary>
    public static class ZodiacSigns
    {
        private static readonly string[] Signs = { "♈", "♉", "♊", "♋", "♌", "♍", "♎", "♏", "♐", "♑", "♒", "♓" };

        /// <summary>
        /// Returns the zodiac sign given by <paramref name="index"/> where Aries is 0 and 11 is Pisces.
        /// </summary>
        /// <param name="index">The index of the Zodiac sign.</param>
        /// <returns>Returns a string containing the Unicode for the Zodiac sign.</returns>
        public static string GetByIndex(int index) =>
            index
                .Check(x => x >= 0 && x < Signs.Length)
                .Apply(x => Signs[x]);
    }
}
