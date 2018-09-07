using System.Diagnostics;

namespace AstroBit.Math
{
    /// <summary>
    /// Represents a circle arc in degrees, minutes and seconds.
    /// </summary>
    [DebuggerDisplay("{ToString()}")]
    public struct Arc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Arc"/> struct.
        /// </summary>
        /// <param name="degrees">The degrees of the arc.</param>
        /// <param name="minutes">The minutes of the arc.</param>
        /// <param name="seconds">The seconds of the arc.</param>
        public Arc(int degrees, int minutes, double seconds)
        {
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
