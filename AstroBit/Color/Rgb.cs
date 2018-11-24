using System;

namespace AstroBit.Color
{
    public class Rgb
    {
        public Rgb(int r, int g, int b)
        {
            R = r.Check(x => 0 <= x && x <= 255);
            G = g.Check(x => 0 <= x && x <= 255);
            B = b.Check(x => 0 <= x && x <= 255);
        }

        public int R { get; }

        public int G { get; }

        public int B { get; }        

        public static Rgb Parse(string color)
        {
            if (color.StartsWith("#"))
            {
                color = color.Substring(1);
            }

            int r = Convert.ToByte(color.Substring(0, 2), 16);
            int g = Convert.ToByte(color.Substring(2, 2), 16);
            int b = Convert.ToByte(color.Substring(4, 2), 16);

            return new Rgb(r, g, b);
        }

        public override string ToString() =>
            $"#{R.ToString("X2")}{G.ToString("X2")}{B.ToString("X2")}".ToLower();
    }

    public static class RgbExtensions
    {
        public static Rgb WithSaturation(this Rgb rgb, int saturation) =>
            new Rgb(
                Math.Min(rgb.R + saturation, 255),
                Math.Min(rgb.G + saturation, 255),
                Math.Min(rgb.B + saturation, 255));
    }
}
