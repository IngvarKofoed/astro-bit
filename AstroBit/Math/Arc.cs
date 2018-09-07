#pragma warning disable SA1407 // Arithmetic expressions must declare precedence

using System;
using System.Diagnostics;

namespace AstroBit.Math
{
    /// <summary>
    /// Represents a circle arc in degrees, minutes and seconds.
    /// </summary>
    [DebuggerDisplay("{ToString()}")]
    public class Arc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Arc"/> class.
        /// </summary>
        /// <param name="degrees">The degrees of the arc.</param>
        /// <param name="minutes">The minutes of the arc.</param>
        /// <param name="seconds">The seconds of the arc.</param>
        /// <exception cref="ArgumentException">if <paramref name="degrees"/> is negative.</exception>
        /// <exception cref="ArgumentException">if <paramref name="minutes"/> is negative.</exception>
        /// <exception cref="ArgumentException">if <paramref name="seconds"/> is negative.</exception>
        /// <remarks>
        /// Seconds and minutes are wrapped and remainder is added to next in line, from seconds to minutes
        /// and minutes to degrees. Degrees is truncated between 0 and 360.
        /// Example: 1 degree, 65 minutes and 65 seconds becomes: 2 degrees, 6 minutes and 5 seconds.
        /// </remarks>
        public Arc(int degrees, int minutes, double seconds)
        {
            if (degrees < 0)
            {
                throw new ArgumentException($"{nameof(degrees)} should be none negative");
            }

            if (minutes < 0)
            {
                throw new ArgumentException($"{nameof(minutes)} should be none negative");
            }

            if (seconds < 0.0)
            {
                throw new ArgumentException($"{nameof(seconds)} should be none negative");
            }

            minutes += (int)seconds / 60;
            seconds = seconds % 60;

            degrees += (int)minutes / 60;
            minutes = minutes % 60;

            degrees = degrees - (degrees / 360) * 360;

            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Gets the degrees of the arc.
        /// </summary>
        public int Degrees { get; }

        /// <summary>
        /// Gets the minutes of the arc.
        /// </summary>
        public int Minutes { get; }

        /// <summary>
        /// Gets the seconds of the arc.
        /// </summary>
        public double Seconds { get; }

        public override string ToString() =>
            $"{Degrees}°{Minutes}'{Seconds:F0}\"";
    }
}
