using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using AstroBit.AstroMath;
using AstroBit.Color;
using AstroBit.IChing;
using AstroBit.Svg;
using AstroBit.Xml;

namespace AstroBit.Mandala
{
    public class SvgMandalaGenerator
    {
        private const double HexagramOffset = 180.0 - 1.75;

        private double CenterX => Width / 2.0;

        private double CenterY => Height / 2.0;

        public int Width { get; set; } = 800;

        public int Height { get; set; } = 800;

        public double Radius { get; set; } = 400;

        public XElement Generate()
        {
            double hexagramInnerRadius = Radius - 60;
            double hexagramOuterRadius = Radius - 10;
            double hexagramLineMarkerInnerRadius = Radius - 10;
            double hexagramLineMarkerOuterRadius = Radius;

            var svgElement = new XElement("svg".SvgName())
                .CreateMonad()
                .Apply(x => x.Add(new XAttribute("width", Width)))
                .Apply(x => x.Add(new XAttribute("height", Height)))
                .Apply(x => x.Add(new XAttribute("viewBox", $"0 0 {Width} {Height}")))
                //.Apply(x => x.Add(CreateZodiacDivisions(CenterX, CenterY, Radius).ToArray()))
                .Apply(x => x.Add(CreateHexagrams(CenterX, CenterY, hexagramInnerRadius, hexagramOuterRadius).ToArray()))
                .Apply(x => x.Add(CreateHexagramDivisions(CenterX, CenterY, hexagramInnerRadius, hexagramLineMarkerOuterRadius).ToArray()))
                .Apply(x => x.Add(CreateHexagramLineMarkers(CenterX, CenterY, hexagramLineMarkerInnerRadius, hexagramLineMarkerOuterRadius).ToArray()))
                .Apply(x => x.AddCircle(CenterX, CenterY, hexagramInnerRadius, "fill:none;stroke:#000000;stroke-width:0.4"))
                .Apply(x => x.AddCircle(CenterX, CenterY, hexagramOuterRadius, "fill:none;stroke:#000000;stroke-width:0.4"));

            //AddHexagramDivisions(svgElement.Value, Radius - 50, Radius);

            return svgElement.Value;
        }

        private static IEnumerable<XElement> CreateZodiacDivisions(double centerX, double centerY, double radius)
        {
            foreach (var number in Enumerable.Range(0, 12))
            {
                var point = CircleMath.GetPoint(30 * number, radius, centerX, centerY);
                yield return SvgBuild.Line(centerX, centerY, point.X, point.Y, "stroke:#000000;stroke-width:0.2");
            }
        }

        private static IEnumerable<XElement> CreateHexagrams(double centerX, double centerY, double innerRadius, double outerRadius)
        {
            foreach (var hexagram in HexagramLL.HexagramsByInnerTrigram)
            {
                var inner1 = CircleMath.GetPoint(HexagramOffset - hexagram.Lines[0].StartDegree, innerRadius, centerX, centerY);
                var inner2 = CircleMath.GetPoint(HexagramOffset - hexagram.Lines[5].EndDegree, innerRadius, centerX, centerY);
                var outer1 = CircleMath.GetPoint(HexagramOffset - hexagram.Lines[0].StartDegree, outerRadius, centerX, centerY);
                var outer2 = CircleMath.GetPoint(HexagramOffset - hexagram.Lines[5].EndDegree, outerRadius, centerX, centerY);

                var points = new[]
                {
                    new SvgPoint(inner1.X, inner1.Y),
                    new SvgPoint(outer1.X, outer1.Y),
                    new SvgPoint(outer2.X, outer2.Y),
                    new SvgPoint(inner2.X, inner2.Y)
                };


                string color = null;
                switch (hexagram.InnerTrigram)
                {
                    case Trigram.Force: // Heaven
                        color = "#ffb3ff";
                        break;

                    case Trigram.Field: // Earth
                        color = "#80ff80";
                        break;

                    case Trigram.Shake: // Thunder
                        color = "#ffff64";
                        break;

                    case Trigram.Gorge: // Water
                        color = "#4d93ff";
                        break;

                    case Trigram.Bound: // Mountain
                        color = "#cccccc";
                        break;

                    case Trigram.Ground: // Wind
                        color = "#99ffff";
                        break;

                    case Trigram.Radiance: // Fire
                        color = "#ff6666";
                        break;

                    case Trigram.Open: // Swamp
                        color = "#00b3a0";
                        break;
                }

                // TODO: This map only works for SOME, the first 4 of: 1, 8, 7, 3, 2, 5, 4, 6
                Dictionary<int, int> blah = new Dictionary<int, int>
                {
                    { 1, 1 },
                    { 2, 8 },
                    { 3, 4 },
                    { 4, 6 },
                    { 5, 7 },
                    { 6, 5 },
                    { 7, 3 },
                    { 8, 2 }
                };

                // TODO: This map only works for SOME, the first 4 of: 1, 8, 7, 3, 2, 5, 4, 6
                Dictionary<int, int> blah2 = new Dictionary<int, int>
                {
                    { 1, 8 },
                    { 2, 1 },
                    { 3, 5 },
                    { 4, 3 },
                    { 5, 2 },
                    { 6, 4 },
                    { 7, 6 },
                    { 8, 7 }
                };
                int[] aa = { 2, 4, 5, 6 };

                if (!aa.Any(x => x == (int)hexagram.InnerTrigram))
                { 
                color = Rgb
                    .Parse(color)
                    .WithSaturation((byte)(7 * (blah[(int)hexagram.OuterTrigram] - 1)))
                    .ToString();
                }
                else
                {
                    color = Rgb
                    .Parse(color)
                    .WithSaturation((byte)(7 * (blah2[(int)hexagram.OuterTrigram] - 1)))
                    .ToString();
                }

                // var color = HexagramLL.FillColors[hexagram.Number];

                var polygon = SvgBuild
                    .Polygon(points, $"hexagram_{hexagram.Number}")
                    //.AddAttribute("class", "hexagram");
                    .AddAttribute("style", $"fill:{color}");

                yield return polygon;
            }
        }

        private static IEnumerable<XElement> CreateHexagramDivisions(double centerX, double centerY, double innerRadius, double outerRadius)
        {
            foreach (var hexagram in HexagramLL.LineStarts)
            {
                var point1 = CircleMath.GetPoint(HexagramOffset - hexagram.Value[0], innerRadius, centerX, centerY);
                var point2 = CircleMath.GetPoint(HexagramOffset - hexagram.Value[0], outerRadius, centerX, centerY);
                yield return SvgBuild.Line(point1.X, point1.Y, point2.X, point2.Y, "stroke:#000000;stroke-width:0.4");
            }
        }

        private static IEnumerable<XElement> CreateHexagramLineMarkers(double centerX, double centerY, double innerRadius, double outerRadius)
        {
            foreach (var angle in HexagramLL.LineStarts.SelectMany(x => x.Value))
            {
                var point1 = CircleMath.GetPoint(HexagramOffset - angle, innerRadius, centerX, centerY);
                var point2 = CircleMath.GetPoint(HexagramOffset - angle, outerRadius, centerX, centerY);
                yield return SvgBuild.Line(point1.X, point1.Y, point2.X, point2.Y, "stroke:#000000;stroke-width:0.2");
            }
        }
    }
}
