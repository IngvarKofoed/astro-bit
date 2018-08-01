using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AstroBit.Ephemeris.Providers.Horizons.Telnet
{
    internal static class TableResultParser
    {
        public static IList<TableEntry> Parse(string result) =>
            result
                .ParseLines()
                .FilterEntries()
                .Select(x => x.LineToEntry())
                .ToList();


        public static string[] ParseLines(this string result) =>
            result.Split(TelnetConstants.NewLine);

        public static IEnumerable<string> FilterEntries(this IEnumerable<string> lines) =>
            lines
                .SkipWhile(s => s != TelnetConstants.TableStartString)
                .TakeWhile(s => s != TelnetConstants.TableEndString)
                .Skip(1);

        public static TableEntry LineToEntry(this string line) =>
            new TableEntry(
                DateTime.Parse(line.Substring(1, 17), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal),
                double.Parse(line.Substring(23, 11), CultureInfo.InvariantCulture),
                double.Parse(line.Substring(35, 11), CultureInfo.InvariantCulture),
                line.Substring(19, 3).Contains("*")
            );

    }
}
