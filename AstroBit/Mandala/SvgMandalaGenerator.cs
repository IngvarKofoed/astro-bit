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
                .Apply(x => x.Add(CreateHexagramLabels(CenterX, CenterY, hexagramInnerRadius, hexagramOuterRadius).ToArray()))
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

                color = Rgb
                    .Parse(color)
                    .WithSaturation(7 * (hexagram.CircleIndex() % 8))
                    .ToString();

                // var color = HexagramLL.FillColors[hexagram.Number];

                var polygon = SvgBuild
                    .Polygon(points, $"hexagram_{hexagram.Number}")
                    //.AddAttribute("class", "hexagram");
                    .AddAttribute("style", $"fill:{color}");

                yield return polygon;
            }
        }

        private static IEnumerable<XElement> CreateHexagramLabels(double centerX, double centerY, double innerRadius, double outerRadius)
        {
            foreach (var hexagram in HexagramLL.HexagramsByInnerTrigram)
            {
                // S: 345, E: 355

                // S: 355, E: 5

                var point = CircleMath.GetPoint(
                    HexagramOffset - (hexagram.Lines[0].StartDegree + (hexagram.Lines[5].EndDegree - hexagram.Lines[0].StartDegree).Truncate(360) / 2.0),
                    innerRadius + (outerRadius - innerRadius) / 2.0,
                    centerX,
                    centerY);

                var text = SvgBuild
                    .Text(point.X, point.Y, hexagram.Number.ToString())
                    .AddAttribute("text-anchor", "middle")
                    .AddAttribute("alignment-baseline", "central")
                    .AddAttribute("style", "font-family: Arial; font-size:20px");
                // TODO: Add text style
                // TODO: Fix angle wrapping EndDegree - StartDegree

                yield return text;
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
