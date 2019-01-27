using System;

namespace AstroBit
{
    public static class ZodiacExtensions
    {
        private static readonly string[] Signs = { "♈", "♉", "♊", "♋", "♌", "♍", "♎", "♏", "♐", "♑", "♒", "♓" };

        public static double GetStartDegree(this Zodiac zodiac)
        {
            switch (zodiac)
            {
                case Zodiac.Aries:
                    return 0.0;

                case Zodiac.Taurus:
                    return 30.0;

                case Zodiac.Gemini:
                    return 60.0;

                case Zodiac.Cancer:
                    return 90.0;

                case Zodiac.Leo:
                    return 120.0;

                case Zodiac.Virgo:
                    return 150.0;

                case Zodiac.Libra:
                    return 180.0;

                case Zodiac.Scorpio:
                    return 210.0;

                case Zodiac.Sagittarius:
                    return 240.0;

                case Zodiac.Capricorn:
                    return 270.0;

                case Zodiac.Aquarius:
                    return 300.0;

                case Zodiac.Pisces:
                    return 330.0;

                default:
                    throw new NotImplementedException();
            }
        }

        public static double GetZodiacLocalStartDegrees(double absoluteDegrees) =>
            ((int)absoluteDegrees / 30) * 30;

        public static double GetZodiacLocalDegrees(double absoluteDegrees) =>
            absoluteDegrees - GetZodiacLocalStartDegrees(absoluteDegrees);

        public static Zodiac GetZodiac(double absoluteDegrees)
        {
            if (absoluteDegrees < 30.0)
            {
                return Zodiac.Aries;
            }
            else if (absoluteDegrees < 60.0)
            {
                return Zodiac.Taurus;
            }
            else if (absoluteDegrees < 90.0)
            {
                return Zodiac.Gemini;
            }
            else if (absoluteDegrees < 120.0)
            {
                return Zodiac.Cancer;
            }
            else if (absoluteDegrees < 150.0)
            {
                return Zodiac.Leo;
            }
            else if (absoluteDegrees < 180.0)
            {
                return Zodiac.Virgo;
            }
            else if (absoluteDegrees < 210.0)
            {
                return Zodiac.Libra;
            }
            else if (absoluteDegrees < 240.0)
            {
                return Zodiac.Scorpio;
            }
            else if (absoluteDegrees < 270.0)
            {
                return Zodiac.Sagittarius;
            }
            else if (absoluteDegrees < 300.0)
            {
                return Zodiac.Capricorn;
            }
            else if (absoluteDegrees < 330.0)
            {
                return Zodiac.Aquarius;
            }
            else if (absoluteDegrees < 360.0)
            {
                return Zodiac.Pisces;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static Zodiac GetDegreeZodiac(this double absoluteDegrees)
        {
            int localDregree = (int)GetZodiacLocalDegrees(absoluteDegrees);
            if (localDregree == 0)
            {
                return GetZodiac(absoluteDegrees);
            }
            else
            {
                int index = (localDregree + 11) % 12;
                return (Zodiac)index;
            }
        }

        public static double GetAbsoluteDegrees(this Zodiac zodiac, double hours, double minutes, double seconds = 0.0) =>
            zodiac.GetStartDegree() + hours + (minutes / 60.0) + (seconds / 3600.0);

        public static string GetSign(this Zodiac zodiac)
        {
            switch (zodiac)
            {
                case Zodiac.Aries:
                    return Signs[0];

                case Zodiac.Taurus:
                    return Signs[1];

                case Zodiac.Gemini:
                    return Signs[2];

                case Zodiac.Cancer:
                    return Signs[3];

                case Zodiac.Leo:
                    return Signs[4];

                case Zodiac.Virgo:
                    return Signs[5];

                case Zodiac.Libra:
                    return Signs[6];

                case Zodiac.Scorpio:
                    return Signs[7];

                case Zodiac.Sagittarius:
                    return Signs[8];

                case Zodiac.Capricorn:
                    return Signs[9];

                case Zodiac.Aquarius:
                    return Signs[10];

                case Zodiac.Pisces:
                    return Signs[11];

                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the zodiac sign given by <paramref name="index"/> where Aries is 0 and 11 is Pisces.
        /// </summary>
        /// <param name="index">The index of the Zodiac sign.</param>
        /// <returns>Returns a string containing the Unicode for the Zodiac sign.</returns>
        public static string GetSignByIndex(int index) =>
            index
                .Check(x => x >= 0 && x < Signs.Length)
                .Apply(x => Signs[x]);
    }
}
