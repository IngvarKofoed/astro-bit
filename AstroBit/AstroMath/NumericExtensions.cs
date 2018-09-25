#pragma warning disable SA1407 // Arithmetic expressions must declare precedence

using System;
using System.Collections.Generic;
using System.Text;

namespace AstroBit.AstroMath
{
    public static class NumericExtensions
    {
        public static double Truncate(this double value, int maxValue) =>
            value - (int)value / maxValue * maxValue + (value < 0.0 ? maxValue : 0);
    }
}
