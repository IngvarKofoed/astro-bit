using System;
using System.Collections.Generic;
using System.Linq;

namespace AstroBit.Svg
{
    public static class PathCommandExtensions
    {
        public static string ToPathString(this IEnumerable<IPathCommand> commands) =>
            commands.Aggregate(string.Empty, (a, c) => a == string.Empty ? c.ToString() : $"{a} {c}");

        public static (double X, double Y) Min(this IEnumerable<IPathCommand> commands) =>
            commands
                .OfType<PathCommandWithPosition>()
                .Select(v => (X: v.X, Y: v.Y))
                .Aggregate(
                    (X: double.MaxValue, Y: double.MaxValue),
                    (a, v) => (Math.Min(a.X, v.X), Math.Min(a.Y, v.Y)));

        public static (double X, double Y) Max(this IEnumerable<IPathCommand> commands) =>
            commands
                .OfType<PathCommandWithPosition>()
                .Select(v => (X: v.X, Y: v.Y))
                .Aggregate(
                    (X: double.MinValue, Y: double.MinValue),
                    (a, v) => (Math.Max(a.X, v.X), Math.Max(a.Y, v.Y)));

        public static (double Width, double Height) GetDimentions(this IEnumerable<IPathCommand> commands)
        {
            var min = commands.Min();
            var max = commands.Max();
            return (max.X - min.X, max.Y - min.Y);
        }

        public static IEnumerable<IPathCommand> Center(this IEnumerable<IPathCommand> commands)
        {
            var offset = commands.GetDimentions().Apply(dim => (X: dim.Width / 2.0, Y: dim.Height / 2.0));
            var min = commands.Min();

            return commands
                .Select(cmd => cmd.Translate(-offset.X - min.X, -offset.Y - min.Y));
        }

        public static IEnumerable<IPathCommand> Normalize(this IEnumerable<IPathCommand> commands) => throw new NotImplementedException();

        public static IEnumerable<IPathCommand> Translate(this IEnumerable<IPathCommand> commands, double dx, double dy) =>
            commands.Select(x => x.Translate(dx, dy));

        public static IEnumerable<IPathCommand> Rotate(this IEnumerable<IPathCommand> commands, double degree) =>
            commands.Select(x => x.Rotate(degree));

        public static IEnumerable<IPathCommand> Scale(this IEnumerable<IPathCommand> commands, double scale) => throw new NotImplementedException();
    }
}
