using AstroBit.IChing;
using System.Collections.Generic;

namespace AstroBit.Mandala
{
    public static class HexagramExtensions
    {
        private static readonly IDictionary<int, int> hexagramNumberToCircleIndex = new Dictionary<int, int>
        {
            { 17, 0 },
            { 21, 1 },
            { 51, 2 },
            { 42, 3 },
            { 3, 4 },
            { 27, 5 },
            { 24, 6 },
            { 2, 7 },
            { 23, 8 },
            { 8, 9 },
            { 20, 10 },
            { 16, 11 },
            { 35, 12 },
            { 45, 13 },
            { 12, 14 },
            { 15, 15 },
            { 52, 16 },
            { 39, 17 },
            { 53, 18 },
            { 62, 19 },
            { 56, 20 },
            { 31, 21 },
            { 33, 22 },
            { 7, 23 },
            { 4, 24 },
            { 29, 25 },
            { 59, 26 },
            { 40, 27 },
            { 64, 28 },
            { 47, 29 },
            { 6, 30 },
            { 46, 31 },
            { 18, 32 },
            { 48, 33 },
            { 57, 34 },
            { 32, 35 },
            { 50, 36 },
            { 28, 37 },
            { 44, 38 },
            { 1, 39 },
            { 43, 40 },
            { 14, 41 },
            { 34, 42 },
            { 9, 43 },
            { 5, 44 },
            { 26, 45 },
            { 11, 46 },
            { 10, 47 },
            { 58, 48 },
            { 38, 49 },
            { 54, 50 },
            { 61, 51 },
            { 60, 52 },
            { 41, 53 },
            { 19, 54 },
            { 13, 55 },
            { 49, 56 },
            { 30, 57 },
            { 55, 58 },
            { 37, 59 },
            { 63, 60 },
            { 22, 61 },
            { 36, 62 },
            { 25, 63 }
        };

        public static int CircleIndex(this Hexagram hexagram) =>
            hexagramNumberToCircleIndex[hexagram.Number] + 1;
    }
}
