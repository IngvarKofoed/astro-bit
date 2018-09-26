#pragma warning disable SA1407 // Arithmetic expressions must declare precedence


namespace AstroBit.AstroMath
{
    public static class AMath
    {
        public const double Epsilon = 0.0001;

        public static double Truncate(this double value, int maxValue) =>
            value - (int)value / maxValue * maxValue + (value < 0.0 ? maxValue : 0);

        public static double Interpolate(double start, double end, double fraction, bool reversed = false)
        {
            double result;

            if (!reversed)
            {
                if (end < start)
                {
                    end += 360.0;
                }

                result = start + ((end - start) * fraction);
            }
            else
            {
                if (start < end)
                {
                    start += 360.0;
                }

                result = start - ((start - end) * fraction);
            }

            return result.Truncate(360);
        }

        public static bool IsInCircleRange(double start, double end, double value)
        {
            if (start <= end)
            {
                return start <= value && value <= end;
            }
            else
            {
                return (start <= value && value <= 360.0) ||
                       (0.0 <= value && value <= end);
            }
        }
    }
}
