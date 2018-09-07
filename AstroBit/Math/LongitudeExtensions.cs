#pragma warning disable SA1407 // Arithmetic expressions must declare precedence

namespace AstroBit.Math
{
    /// <summary>
    /// Extension methods for <see cref="Longitude"/>.
    /// </summary>
    public static class LongitudeExtensions
    {
        /// <summary>
        /// Converts the given <paramref name="longitude"/> to degrees in the range of [-180, 180]
        /// where 0 is the prime meridian.
        /// </summary>
        /// <param name="longitude">The longitude to convert.</param>
        /// <returns>Returns the longitude in degrees.</returns>
        public static double ToDegrees(this Longitude longitude) =>
            longitude.GetDirectionFactor() * (longitude.Degrees + longitude.Minutes / 60.0 + longitude.Seconds / 3600.0);

        private static int GetDirectionFactor(this Longitude longitude) =>
            longitude.Direction == LongitudeDirection.East ? 1 : -1;
    }
}
