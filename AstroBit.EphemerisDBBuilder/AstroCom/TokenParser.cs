using System;
using System.Collections.Generic;
using System.Linq;

namespace AstroBit.EphemerisDBBuilder.AstroCom
{
    public class TokenParser
    {
        private readonly string line;
        private int index = 0;

        private static readonly char[] DayLetters = new[] { 'M', 'T', 'W', 'T', 'F', 'S', 'S' };
        private static readonly char[] Digits = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static readonly Dictionary<char, Zodiac> CharToZodiac = new Dictionary<char, Zodiac>
            {
                { 'a', Zodiac.Aries },
                { 'b', Zodiac.Taurus },
                { 'c', Zodiac.Gemini },
                { 'd', Zodiac.Cancer },
                { 'e', Zodiac.Leo },
                { 'f', Zodiac.Virgo },
                { 'g', Zodiac.Libra },
                { 'h', Zodiac.Scorpio },
                { 'i', Zodiac.Sagittarius },
                { 'j', Zodiac.Capricorn },
                { 'k', Zodiac.Aquarius },
                { 'l', Zodiac.Pisces },
            };

        public TokenParser(string line)
        {
            this.line = line;
        }

        public bool Empty => index == line.Length;

        public string ReadDayLetter()
        {
            if (!IsCurrentDayLetter)
            {
                throw new InvalidOperationException($"Parse error: Expected day letter at index {index}");
            }

            var result = ReadCharecter();

            OptionalSkipSpace();

            return result;
        }

        public int ReadNumber(bool readSpaceAfter = true)
        {
            if (!IsCurrentDigit)
            {
                throw new InvalidOperationException($"Parse error: Expected digits at index {index}");
            }

            string number = ReadCharecter();
            while (IsCurrentDigit)
            {
                number += ReadCharecter();
            }

            if (readSpaceAfter)
            {
                ReadSpace();
            }

            return int.Parse(number);
        }

        public Zodiac? ReadDegreeSeperator()
        {
            if (CurrentCharecter != '°' && !CharToZodiac.Keys.Contains(CurrentCharecter))
            {
                throw new InvalidOperationException($"Parse error: Expected '°' or Zodiac char at index {index}");
            }

            var charecter = ReadCharecter()[0];

            if (charecter == '°')
            {
                return null;
            }
            else
            {
                return CharToZodiac[charecter];
            }
        }


        public string ReadSecondSeperator()
        {
            if (CurrentCharecter != '\'')
            {
                throw new InvalidOperationException($"Parse error: Expected \' at index {index}");
            }

            return ReadCharecter();
        }

        public PlanetDirection? OptionalReadDirection()
        {
            if (CurrentCharecter == 'R')
            {
                ReadCharecter();
                return PlanetDirection.Retrograde;
            }
            else if (CurrentCharecter == 'D')
            {
                ReadCharecter();
                return PlanetDirection.Direct;
            }
            else
            {
                return null;
            }
        }

        public void OptionalSkipSpace()
        {
            if (CurrentCharecter == ' ')
            {
                ReadCharecter();
            }
        }

        private char CurrentCharecter =>
            line[index];

        private bool IsCurrentDayLetter =>
            IsDayLetter(CurrentCharecter);

        private bool IsCurrentDigit =>
            IsDigit(CurrentCharecter);

        private string ReadCharecter() =>
            line[index++].ToString();

        private void ReadSpace()
        {
            if (CurrentCharecter != ' ')
            {
                throw new InvalidOperationException($"Parse error: Expected space at index {index}");
            }

            ReadCharecter();
        }

        private static bool IsDayLetter(char charecter) =>
            DayLetters.Contains(charecter);

        private static bool IsDigit(char charecter) =>
            Digits.Contains(charecter);
    }
}
