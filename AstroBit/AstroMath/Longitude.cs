namespace AstroBit.AstroMath
{
    /// <summary>
    /// The direction of a <see cref="Longitude"/>.
    /// </summary>
    public enum LongitudeDirection
    {
        /// <summary>
        /// East
        /// </summary>
        East,

        /// <summary>
        /// West
        /// </summary>
        West
    }

    /// <summary>
    /// Represents a longitude on a sphere.
    /// </summary>
    public class Longitude : Arc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Longitude"/> class.
        ///
        /// </summary>
        /// <param name="degrees">The degrees of the longitude.</param>
        /// <param name="minutes">The minutes of the longitude.</param>
        /// <param name="seconds">The seconds of the longitude.</param>
        /// <param name="direction">The direction of the longitude.</param>
        public Longitude(int degrees, int minutes, double seconds, LongitudeDirection direction)
            : base(degrees, minutes, seconds)
        {
            Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Longitude"/> class.
        ///
        /// </summary>
        /// <param name="arc">The arc of the longitude.</param>
        /// <param name="direction">The direction of the longitude.</param>
        public Longitude(Arc arc, LongitudeDirection direction)
            : this(arc.Degrees, arc.Minutes, arc.Seconds, direction)
        {
        }

        /// <summary>
        /// Gets the direction of the longitude.
        /// </summary>
        public LongitudeDirection Direction { get; }

        public override string ToString() =>
            $"{base.ToString()}{Direction.ToString()[0]}";
    }
}
