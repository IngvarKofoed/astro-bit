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
                .Apply(x => x.Add(CreateZodiacs(CenterX, CenterY, hexagramInnerRadius - 50, hexagramInnerRadius).ToArray()))
                .Apply(x => x.AddCircle(CenterX, CenterY, hexagramInnerRadius, "fill:none;stroke:#000000;stroke-width:0.4"))
                .Apply(x => x.AddCircle(CenterX, CenterY, hexagramOuterRadius, "fill:none;stroke:#000000;stroke-width:0.4"));

            //var path = PathBuilderParser
            //    .Parse("M 64.28125,95.179581 L 64.28125,91.398331 C 64.281226,88.419171 63.635393,83.106676 62.34375,75.460831 C 61.760395,71.856687 60.802062,68.106691 59.46875,64.210831 C 58.114565,60.252532 56.6979,57.148369 55.21875,54.898331 C 54.072902,53.190039 52.70832,52.335874 51.125,52.335831 C 49.333324,52.335874 48.083325,53.023373 47.375,54.398331 C 46.72916,55.669204 46.406243,57.054619 46.40625,58.554581 C 46.406243,61.721281 47.541659,64.585861 49.8125,67.148331 L 44.5,67.148331 C 42.666664,64.335862 41.749998,61.367115 41.75,58.242081 C 41.749998,54.971288 42.624997,52.40879 44.375,50.554581 C 46.187494,48.637961 48.385408,47.679628 50.96875,47.679581 C 54.302069,47.679628 56.906233,49.054627 58.78125,51.804581 C 60.906229,54.908788 62.67706,58.679617 64.09375,63.117081 C 65.093725,66.346276 65.937474,69.919189 66.625,73.835831 C 67.312472,69.919189 68.156222,66.346276 69.15625,63.117081 C 70.489553,58.783784 72.260384,55.012954 74.46875,51.804581 C 76.343713,49.054627 78.947878,47.679628 82.28125,47.679581 C 84.864538,47.679628 87.062453,48.637961 88.875,50.554581 C 90.624949,52.40879 91.499948,54.971288 91.5,58.242081 C 91.499948,61.367115 90.583283,64.335862 88.75,67.148331 L 83.4375,67.148331 C 85.708287,64.585861 86.843703,61.721281 86.84375,58.554581 C 86.843703,57.054619 86.520787,55.669204 85.875,54.398331 C 85.166621,53.023373 83.916623,52.335874 82.125,52.335831 C 80.541626,52.335874 79.177044,53.190039 78.03125,54.898331 C 76.552047,57.148369 75.135381,60.252532 73.78125,64.210831 C 72.447884,68.106691 71.489552,71.856687 70.90625,75.460831 C 69.614554,83.106676 68.968721,88.419171 68.96875,91.398331 L 68.96875,95.179581 L 64.28125,95.179581")
            //    .ToArray();
            //var svgElement = new XElement("svg".SvgName())
            //    .CreateMonad()
            //    .Apply(x => x.Add(SvgBuild.Path(new PathBuilder(path)).AddAttribute("style", "fill: #000000")))
            //    .Apply(x => x.Add(SvgBuild.Path(new PathBuilder(path.CenterAtZero())).AddAttribute("style", "fill: #000000")));



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

        public IEnumerable<XElement> CreateZodiacs(double centerX, double centerY, double innerRadius, double outerRadius)
        {
            foreach (var index in Enumerable.Range(0, 12))
            {
                var innserStart = CircleMath.GetPoint(GetAngle(index * 30), innerRadius, centerX, centerY);
                PathBuilder path = new PathBuilder(innserStart.X, innserStart.Y);

                foreach (var subIndex in Enumerable.Range(1, 6))
                {
                    var inner = CircleMath.GetPoint(GetAngle(index * 30 + subIndex * 5), innerRadius, centerX, centerY);
                    path = path.LineTo(inner.X, inner.Y);
                }

                foreach (var subIndex in Enumerable.Range(0, 7))
                {
                    var outer = CircleMath.GetPoint(GetAngle(index * 30 + 30 - subIndex * 5), outerRadius, centerX, centerY);
                    path = path.LineTo(outer.X, outer.Y);
                }

                yield return SvgBuild
                    .Path(path.Close())
                    .AddSvgStyle($"fill: {Rgb.From(100, index * 10 + 120, 100)}");


                var zodiacCenter = CircleMath.GetPoint(GetAngle(index * 30 + 15), innerRadius + (outerRadius - innerRadius) / 2.0, centerX, centerY);

                var zodiacPath = PathBuilderParser
                    .Parse("M 64.28125,95.179581 L 64.28125,91.398331 C 64.281226,88.419171 63.635393,83.106676 62.34375,75.460831 C 61.760395,71.856687 60.802062,68.106691 59.46875,64.210831 C 58.114565,60.252532 56.6979,57.148369 55.21875,54.898331 C 54.072902,53.190039 52.70832,52.335874 51.125,52.335831 C 49.333324,52.335874 48.083325,53.023373 47.375,54.398331 C 46.72916,55.669204 46.406243,57.054619 46.40625,58.554581 C 46.406243,61.721281 47.541659,64.585861 49.8125,67.148331 L 44.5,67.148331 C 42.666664,64.335862 41.749998,61.367115 41.75,58.242081 C 41.749998,54.971288 42.624997,52.40879 44.375,50.554581 C 46.187494,48.637961 48.385408,47.679628 50.96875,47.679581 C 54.302069,47.679628 56.906233,49.054627 58.78125,51.804581 C 60.906229,54.908788 62.67706,58.679617 64.09375,63.117081 C 65.093725,66.346276 65.937474,69.919189 66.625,73.835831 C 67.312472,69.919189 68.156222,66.346276 69.15625,63.117081 C 70.489553,58.783784 72.260384,55.012954 74.46875,51.804581 C 76.343713,49.054627 78.947878,47.679628 82.28125,47.679581 C 84.864538,47.679628 87.062453,48.637961 88.875,50.554581 C 90.624949,52.40879 91.499948,54.971288 91.5,58.242081 C 91.499948,61.367115 90.583283,64.335862 88.75,67.148331 L 83.4375,67.148331 C 85.708287,64.585861 86.843703,61.721281 86.84375,58.554581 C 86.843703,57.054619 86.520787,55.669204 85.875,54.398331 C 85.166621,53.023373 83.916623,52.335874 82.125,52.335831 C 80.541626,52.335874 79.177044,53.190039 78.03125,54.898331 C 76.552047,57.148369 75.135381,60.252532 73.78125,64.210831 C 72.447884,68.106691 71.489552,71.856687 70.90625,75.460831 C 69.614554,83.106676 68.968721,88.419171 68.96875,91.398331 L 68.96875,95.179581 L 64.28125,95.179581")
                    .Center()
                    .Normalize()
                    .Scale(30.0)
                    .Rotate(GetAngle(index * 30 + 15 - 90))
                    .Translate(zodiacCenter.X, zodiacCenter.Y)
                    .ToBuilder();

                yield return SvgBuild
                    .Path(zodiacPath.Close())
                    .AddSvgStyle("fill: #440044");
            }
        }

        private double GetAngle(double localAngle) =>
            HexagramOffset - localAngle;
    }
}
