using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AstroBit.EphemerisDBBuilder.AstroCom
{
    public class Parser
    {        
        private string[] lines;
        private int index = 0;
        private EphemerisEntry previousEntry;

        private static readonly string[] Months = new[]
        {
                "JANUARY",
                "FEBRUARY",
                "MARCH",
                "APRIL",
                "MAY",
                "JUNE",
                "JULY",
                "AUGUST",
                "SEPTEMBER",
                "OCTOBER",
                "NOVEMBER",
                "DECEMBER"
            };

        public Parser(string text, EphemerisEntry previousEntry)
        {            
            lines = Regex.Split(text, "\r\n|\r|\n");
            this.previousEntry = previousEntry;
        }

        public IEnumerable<EphemerisEntry> Parse(int year)
        {
            index = 0;

            for (int i = 0; i < Months.Length; i++)
            {
                GotoMonth(Months[i]);

                string line = GetNextLine();
                while (line != null)
                { 
                    var entry = RowParser.Parse(year, i + 1, line, previousEntry);
                    previousEntry = entry;
                    yield return entry;

                    line = GetNextLine();
                }
            }
        }

        private void GotoMonth(string month)
        {
            while (index < lines.Length && !lines[index].StartsWith(month))
            {
                index++;
            }

            if (index >= lines.Length)
            {
                throw new InvalidOperationException($"Month {month} not found");
            }

            index += 2; // Skip Header
        }

        private string GetNextLine()
        {
            if (lines[index].StartsWith("Delta"))
            {
                return null;
            }

            return lines[index++];
        }
    }
}
