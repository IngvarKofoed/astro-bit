using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AstroBit.Svg
{
    public class PathBuilderParser
    {
        public static IEnumerable<IPathCommand> Parse(string path)
        {
            if (path == string.Empty)
            {
                yield break;
            }

            int endIndex = GetEndIndex(path);
            var numbers = path.Substring(1, endIndex - 2).Trim();

            if (path.StartsWith("M"))
            {
                var (x, y) = ParseTwoNumbers(numbers);
                yield return new MoveToPathCommand(x, y);
            }
            else if (path.StartsWith("L"))
            {
                var (x, y) = ParseTwoNumbers(numbers);
                yield return new LineToPathCommand(x, y);
            }
            else if (path.StartsWith("C"))
            {
                var numbersSplit = numbers.Split(' ');
                var (cx1, cy1) = ParseTwoNumbers(numbersSplit[0]);
                var (cx2, cy2) = ParseTwoNumbers(numbersSplit[1]);
                var (x, y) = ParseTwoNumbers(numbersSplit[2]);
                yield return new CubicBezierPathCommand(x, y, cx1, cy1, cx2, cy2);
            }
            else
            {
                throw new NotFiniteNumberException();
            }

            var pathRest = path.Substring(endIndex).Trim();
            if (pathRest.Length == 1)
            {
                pathRest = string.Empty;
            }

            foreach (var command in Parse(pathRest))
            {
                yield return command;
            }
        }

        private static (double x, double y) ParseTwoNumbers(string numbers)
        {
            var split = numbers.Trim().Split(',');
            var x = double.Parse(split[0], CultureInfo.InvariantCulture);
            var y = double.Parse(split[1], CultureInfo.InvariantCulture);
            return (x, y);
        }

        private static int GetEndIndex(string path) =>
            new[]
            {
                GetEndIndex(path, 'M'),
                GetEndIndex(path, 'L'),
                GetEndIndex(path, 'H'),
                GetEndIndex(path, 'V'),
                GetEndIndex(path, 'C'),
                GetEndIndex(path, 'S'),
                GetEndIndex(path, 'Q'),
                GetEndIndex(path, 'T'),
                GetEndIndex(path, 'A'),
                GetEndIndex(path, 'Z')
            }
            .Min();

        private static int GetEndIndex(string path, char charecter) =>
            path
                .IndexOf(charecter, 1)
                .Apply(x => x != -1 ? x : path.Length - 1);
    }
}
