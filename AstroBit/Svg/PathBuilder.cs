using System.Collections.Generic;

namespace AstroBit.Svg
{
    public class PathBuilder
    {
        private readonly List<IPathCommand> commands = new List<IPathCommand>();

        public PathBuilder(double x, double y)
        {
            commands.Add(new MoveToPathCommand(x, y));
        }

        public PathBuilder(IEnumerable<IPathCommand> pathCommands)
        {
            commands.AddRange(pathCommands);
        }

        public PathBuilder LineTo(double x, double y)
        {
            commands.Add(new LineToPathCommand(x, y));
            return this;
        }

        public PathBuilder CubicBezierCurve(double x, double y, double cx1, double cy1, double cx2, double cy2)
        {
            commands.Add(new CubicBezierPathCommand(x, y, cx1, cy1, cx2, cy2));
            return this;
        }

        public PathBuilder Close()
        {
            commands.Add(new ClosePathCommand());
            return this;
        }

        public override string ToString() =>
            commands.ToPathString();
    }
}