using System.Globalization;

namespace AstroBit.Svg
{
    public static class StringExtensions
    {
        public static string ToInvariantString(this double value) =>
            value.ToString("0.######", CultureInfo.InvariantCulture);
    }
}
