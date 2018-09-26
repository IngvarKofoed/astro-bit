using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace AstroBit.HumanDesign.DBBuilder.HumanDesignSystemCom
{
    public class Parser
    {
        private string[] lines;
        private int index = 0;

        private static readonly string[] Trigrams = new[]
        {
            "HEAVEN",
            "LAKE",
            "FIRE",
            "THUNDER",
            "EARTH",
            "MOUNTAIN",
            "WATER",
            "WIND"
        };

        public Parser(string text)
        {
            lines = Regex.Split(text, "\r\n|\r|\n");
        }


        public List<Gate> Parse()
        {
            index = 0;

            List<Gate> gates = new List<Gate>();

            foreach (var trigram in Trigrams)
            {
                GotoTrigram(trigram);

                var gates1 = ParseGates(first: true);
                var gates2 = ParseGates(first: false);

                gates.AddRange(gates1);
                gates.AddRange(gates2);
            }

            return gates.OrderBy(x => x.Number).ToList();
        }

        private string CurrentLine =>
            lines[index];

        private int[] ParseGatesHeader()
        {
            var parser = new TokenParser(CurrentLine);

            var gateNumber1 = parser.ReadNumber();
            parser.SkipUntilNumber();
            var gateNumber2 = parser.ReadNumber();
            parser.SkipUntilNumber();
            var gateNumber3 = parser.ReadNumber();
            parser.SkipUntilNumber();
            var gateNumber4 = parser.ReadNumber();

            index++;

            return new int[]
            {
                gateNumber1,
                gateNumber2,
                gateNumber3,
                gateNumber4
            };
        }

        private List<Gate> ParseGates(bool first = true)
        {
            var gateNumbers = ParseGatesHeader();

            var gateLines = new Dictionary<int, List<Line>>();
            foreach (var gateNumber in gateNumbers)
            {
                gateLines.Add(gateNumber, new List<Line>());
            }

            for (int i = 0; i < 6; i++)
            {
                // Lines belongs to gates in this order: 2, 4, 1, 3 => indexed: 1, 3, 0, 2
                var lines1 = ParseGateRow();
                var lines2 = ParseGateRow();

                if (first) // Order: 2, 4, 1, 3
                { 
                    gateLines[gateNumbers[0]].Add(lines2[0]);
                    gateLines[gateNumbers[1]].Add(lines1[0]);
                    gateLines[gateNumbers[2]].Add(lines2[1]);
                    gateLines[gateNumbers[3]].Add(lines1[1]);
                }
                else // Order: 1, 3, 2, 4
                {
                    gateLines[gateNumbers[0]].Add(lines1[0]);
                    gateLines[gateNumbers[1]].Add(lines2[0]);
                    gateLines[gateNumbers[2]].Add(lines1[1]);
                    gateLines[gateNumbers[3]].Add(lines2[1]);
                }
            }

            return gateLines
                .Select(kvp => new Gate(kvp.Key, kvp.Value))
                .ToList();
        }

        private Line[] ParseGateRow()
        {
            var parser = new TokenParser(CurrentLine);

            parser.ReadSpace();
            var line1 = ParseGateRowInterval(parser);

            parser.ReadSpace();
            var line2 = ParseGateRowInterval(parser);

            index++;

            return new Line[]
            {
                line1,
                line2
            };
        }

        private Line ParseGateRowInterval(TokenParser parser)
        {
            //  1 18°52’30’’hh–19°48’45’’hh 1 00°07’30’’ii–01°03’45’’ii
            
            var number = parser.ReadNumber();
            var hours1 = parser.ReadNumber(false);
            parser.ReadHourSeperator();
            var minutes1 = parser.ReadNumber(false);
            parser.ReadMinuteSeperator();
            var seconds1 = parser.ReadNumber(false);
            parser.ReadSecondSeperator();
            var zodiac1 = parser.ReadZodiac();

            parser.ReadDash();

            var hours2 = parser.ReadNumber(false);
            parser.ReadHourSeperator();
            var minutes2 = parser.ReadNumber(false);
            parser.ReadMinuteSeperator();
            var seconds2 = parser.ReadNumber(false);
            parser.ReadSecondSeperator();
            var zodiac2 = parser.ReadZodiac();

            double startInterval = zodiac1.GetAbsoluteDegrees(hours1, minutes1, seconds1);
            double endInterval = zodiac2.GetAbsoluteDegrees(hours2, minutes2, seconds2);

            return new Line(number, startInterval, endInterval);
        }

        private void GotoTrigram(string trigram)
        {
            while (index < lines.Length && !CurrentLine.Contains(trigram))
            {
                index++;
            }

            if (index >= lines.Length)
            {
                throw new InvalidOperationException($"Trigram {trigram} not found");
            }

            index++;
        }        
    }
}
