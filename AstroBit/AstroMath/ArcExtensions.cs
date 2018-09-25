#pragma warning disable SA1407 // Arithmetic expressions must declare precedence

using System;

namespace AstroBit.AstroMath
{
    /// <summary>
    /// Extension methods for <see cref="Arc"/>.
    /// </summary>
    public static class ArcExtensions
    {
        /// <summary>
        /// Converts the given <paramref name="arc"/> into a <see cref="TimeSpan"/>
        /// where there are 24 hours on a full circle.
        /// </summary>
        /// <param name="arc">The arc to convert.</param>
        /// <returns>Returns the time for the given arc where 360 degrees is 24 hours.</returns>
        public static TimeSpan ToTime(this Arc arc)
        {
            int hours = arc.Degrees / 15;
            int minutes = (arc.Degrees % 15) * 4 + (arc.Minutes / 15);
            int seconds = (arc.Minutes % 15) * 4 + (int)(arc.Seconds / 15);

            return TimeSpan.FromSeconds(hours * 3600 + minutes * 60 + seconds);
        }

        public static Arc ToArc(this double decimalHours)
        {
            var degrees = (int)decimalHours; // Floor
            var minutes = (int)Math.Round((decimalHours - degrees) * 60.0, 2); // Leave room for minutes and seconds
            var seconds = Math.Clamp((decimalHours - degrees - (minutes / 60.0)) * 3600.0, 0.0, 60.0); // Remove rounding errors
            return new Arc(degrees, minutes, seconds);
        }
    }
}
