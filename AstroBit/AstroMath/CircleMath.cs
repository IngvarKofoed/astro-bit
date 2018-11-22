using System;

namespace AstroBit.AstroMath
{
    public static class CircleMath
    {
        private const double DegreesToRadiants = Math.PI / 180.0;

        public static Point GetPoint(double degrees, double radius, double x, double y)
        {
            double radianAngle = DegreesToRadiants * degrees;
            double resultX = x + Math.Cos(radianAngle) * radius;
            double resultY = y + Math.Sin(radianAngle) * radius;
            return new Point(resultX, resultY);
        }
    }
}
