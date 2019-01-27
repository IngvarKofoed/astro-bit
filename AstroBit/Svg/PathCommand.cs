using System;

namespace AstroBit.Svg
{
    public interface IPathCommand
    {
        IPathCommand Translate(double dx, double dy);

        IPathCommand Rotate(double degrees);
    }

    public abstract class PathCommandWithPosition : IPathCommand
    {
        public PathCommandWithPosition(double x, double y)
        {
            X = x.IsNumber();
            Y = y.IsNumber();
        }

        public double X { get; }

        public double Y { get; }

        public abstract IPathCommand Translate(double dx, double dy);

        public abstract IPathCommand Rotate(double degrees);

        protected (double X, double Y) Rotate(double x, double y, double degrees) =>
            (x * Math.Cos(Math.PI / 180.0 * degrees) - y * Math.Sin(Math.PI / 180.0 * degrees),
             y * Math.Cos(Math.PI / 180.0 * degrees) + x * Math.Sin(Math.PI / 180.0 * degrees));
    }

    public class ClosePathCommand : IPathCommand
    {
        public IPathCommand Translate(double dx, double dy) => this;

        public IPathCommand Rotate(double degrees) => this;

        public override string ToString() =>
            $"Z";
    }

    public class MoveToPathCommand : PathCommandWithPosition
    {
        public MoveToPathCommand(double x, double y)
            : base(x, y)
        {
        }

        public override IPathCommand Translate(double dx, double dy) =>
            new MoveToPathCommand(X + dx, Y + dy);

        public override IPathCommand Rotate(double degrees) =>
            Rotate(X, Y, degrees)
            .Apply(p => new MoveToPathCommand(p.X, p.Y));

        public override string ToString() =>
            $"M {X.ToInvariantString()},{Y.ToInvariantString()}";
    }

    public class LineToPathCommand : PathCommandWithPosition
    {
        public LineToPathCommand(double x, double y)
        : base(x, y)
        {
        }

        public override IPathCommand Translate(double dx, double dy) =>
            new LineToPathCommand(X + dx, Y + dy);

        public override IPathCommand Rotate(double degrees) =>
            Rotate(X, Y, degrees)
            .Apply(p => new LineToPathCommand(p.X, p.Y));

        public override string ToString() =>
            $"L {X.ToInvariantString()},{Y.ToInvariantString()}";
    }

    public class CubicBezierPathCommand : PathCommandWithPosition
    {
        public CubicBezierPathCommand(double x, double y, double cx1, double cy1, double cx2, double cy2)
        : base(x, y)
        {
            CX1 = cx1.IsNumber();
            CY1 = cy1.IsNumber();
            CX2 = cx2.IsNumber();
            CY2 = cy2.IsNumber();
        }

        public double CX1 { get; }

        public double CY1 { get; }

        public double CX2 { get; }

        public double CY2 { get; }

        public override IPathCommand Translate(double dx, double dy) =>
            new CubicBezierPathCommand(X + dx, Y + dy, CX1 + dx, CY1 + dy, CX2 + dx, CY2 + dy);

        public override IPathCommand Rotate(double degrees)
        {
            var p = Rotate(X, Y, degrees);
            var c1 = Rotate(CX1, CY1, degrees);
            var c2 = Rotate(CX2, CY2, degrees);
            return new CubicBezierPathCommand(p.X, p.Y, c1.X, c1.Y, c2.X, c2.Y);
        }

        public override string ToString() =>
            $"C {CX1.ToInvariantString()},{CY1.ToInvariantString()} {CX2.ToInvariantString()},{CY2.ToInvariantString()} {X.ToInvariantString()},{Y.ToInvariantString()}";
    }
}
