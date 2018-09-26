using System;
using System.Collections.Generic;
using System.Linq;

namespace AstroBit.HumanDesign.DBBuilder.HumanDesignSystemCom
{
    public class TokenParser
    {
        private readonly string line;
        private int index = 0;

        //private static readonly char[] DayLetters = new[] { 'M', 'T', 'W', 'T', 'F', 'S', 'S' };
        private static readonly char[] Digits = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static readonly Dictionary<string, Zodiac> StringToZodiac = new Dictionary<string, Zodiac>
            {
                { "aa", Zodiac.Aries },
                { "bb", Zodiac.Taurus },
                { "cc", Zodiac.Gemini },
                { "dd", Zodiac.Cancer },
                { "ee", Zodiac.Leo },
                { "ff", Zodiac.Virgo },
                { "gg", Zodiac.Libra },
                { "hh", Zodiac.Scorpio },
                { "ii", Zodiac.Sagittarius },
                { "jj", Zodiac.Capricorn },
                { "kk", Zodiac.Aquarius },
                { "ll", Zodiac.Pisces },
            };

        public TokenParser(string line)
        {
            this.line = line;
        }

        public bool Empty => index == line.Length;

        //public string ReadDayLetter()
        //{
        //    if (!IsCurrentDayLetter)
        //    {
        //        throw new InvalidOperationException($"Parse error: Expected day letter at index {index}");
        //    }

        //    var result = ReadCharecter();

        //    OptionalSkipSpace();

        //    return result;
        //}

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

        public void ReadSpace()
        {
            if (CurrentCharecter != ' ')
            {
                throw new InvalidOperationException($"Parse error: Expected space at index {index}");
            }

            ReadCharecter();
        }

        public void ReadHourSeperator()
        {
            if (CurrentCharecter != '°')
            {
                throw new InvalidOperationException($"Parse error: Expected ° at index {index}");
            }

            ReadCharecter();
        }

        public void ReadMinuteSeperator()
        {
            if (CurrentCharecter != '’')
            {
                throw new InvalidOperationException($"Parse error: Expected ’ at index {index}");
            }

            ReadCharecter();
        }

        public void ReadSecondSeperator()
        {
            if (CurrentCharecter != '’')
            {
                throw new InvalidOperationException($"Parse error: Expected ’ at index {index}");
            }

            ReadCharecter();

            if (CurrentCharecter != '’')
            {
                throw new InvalidOperationException($"Parse error: Expected ’ at index {index}");
            }

            ReadCharecter();
        }

        public Zodiac ReadZodiac()
        {
            string zodiac = ReadCharecter() + ReadCharecter();
            if (!StringToZodiac.ContainsKey(zodiac))
            {
                throw new InvalidOperationException($"Parse error: Expected zodiac at index {index - 2}");
            }

            return StringToZodiac[zodiac];
        }

        public void ReadDash()
        {
            if (CurrentCharecter != '–')
            {
                throw new InvalidOperationException($"Parse error: Expected ’ at index {index}");
            }

            ReadCharecter();
        }

        public void SkipUntilNumber()
        {
            while (!IsCurrentDigit)
            {
                ReadCharecter();
            }
        }

        //public Zodiac? ReadDegreeSeperator()
        //{
        //    if (CurrentCharecter != '°' && !CharToZodiac.Keys.Contains(CurrentCharecter))
        //    {
        //        throw new InvalidOperationException($"Parse error: Expected '°' or Zodiac char at index {index}");
        //    }

        //    var charecter = ReadCharecter()[0];

        //    if (charecter == '°')
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return CharToZodiac[charecter];
        //    }
        //}


        //public string ReadSecondSeperator()
        //{
        //    if (CurrentCharecter != '\'')
        //    {
        //        throw new InvalidOperationException($"Parse error: Expected \' at index {index}");
        //    }

        //    return ReadCharecter();
        //}

        //public PlanetDirection? OptionalReadDirection()
        //{
        //    if (CurrentCharecter == 'R')
        //    {
        //        ReadCharecter();
        //        return PlanetDirection.Retrograde;
        //    }
        //    else if (CurrentCharecter == 'D')
        //    {
        //        ReadCharecter();
        //        return PlanetDirection.Direct;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        public void OptionalSkipSpace()
        {
            if (CurrentCharecter == ' ')
            {
                ReadCharecter();
            }
        }

        private char CurrentCharecter =>
            line[index];

        //private bool IsCurrentDayLetter =>
        //    IsDayLetter(CurrentCharecter);

        private bool IsCurrentDigit =>
            IsDigit(CurrentCharecter);

        private string ReadCharecter() =>
            line[index++].ToString();

        //private static bool IsDayLetter(char charecter) =>
        //    DayLetters.Contains(charecter);

        private static bool IsDigit(char charecter) =>
            Digits.Contains(charecter);
    }
}
