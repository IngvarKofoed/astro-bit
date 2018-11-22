using System;

namespace AstroBit.Color
{
    public class Rgb
    {
        public Rgb(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public byte R { get; }

        public byte G { get; }

        public byte B { get; }        

        public static Rgb Parse(string color)
        {
            if (color.StartsWith("#"))
            {
                color = color.Substring(1);
            }

            byte r = Convert.ToByte(color.Substring(0, 2), 16);
            byte g = Convert.ToByte(color.Substring(2, 2), 16);
            byte b = Convert.ToByte(color.Substring(4, 2), 16);

            return new Rgb(r, g, b);
        }

        public override string ToString() =>
            $"#{R.ToString("X2")}{G.ToString("X2")}{B.ToString("X2")}".ToLower();
    }

    public static class RgbExtensions
    {
        public static Rgb WithSaturation(this Rgb rgb, byte saturation) =>
            new Rgb(
                (byte)Math.Min(rgb.R + saturation, 255),
                (byte)Math.Min(rgb.G + saturation, 255),
                (byte)Math.Min(rgb.B + saturation, 255));
    }
}
