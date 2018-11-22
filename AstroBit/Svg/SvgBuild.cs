using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using AstroBit.Xml;

namespace AstroBit.Svg
{
    public static class SvgBuild
    {
        public static XName SvgName(this string name) =>
            XName.Get(name, "http://www.w3.org/2000/svg");

        public static XElement SvgElement(this XDocument document) =>
            document.Root;

        public static XElement Line(double x1, double y1, double x2, double y2, string style, string id = null)
        {
            var line = new XElement("line".SvgName());
            line.AddAttribute("x1", x1);
            line.AddAttribute("y1", y1);
            line.AddAttribute("x2", x2);
            line.AddAttribute("y2", y2);
            line.AddAttribute("style", style);
            line.SafeAddIdAttribute(id);
            return line;
        }

        public static XElement AddLine(this XElement element, double x1, double y1, double x2, double y2, string style, string id = null)
        {
            element.Add(Line(x1, y1, x2, y2, style, id));
            return element;
        }

        public static XElement Circle(double cx, double cy, double radius, string style, string id = null)
        {
            var circle = new XElement("circle".SvgName());
            circle.AddAttribute("cx", cx);
            circle.AddAttribute("cy", cy);
            circle.AddAttribute("r", radius);
            circle.AddAttribute("style", style);
            circle.SafeAddIdAttribute(id);
            return circle;
        }

        public static XElement AddCircle(this XElement element, double cx, double cy, double radius, string style, string id = null)
        {
            element.Add(Circle(cx, cy, radius, style, id));
            return element;
        }

        public static XElement Polygon(IEnumerable<SvgPoint> points, string id = null)
        {
            var pointsString = points.Aggregate(string.Empty, (a, p) => $"{a}{(a == string.Empty ? string.Empty : " ")}{p.X.ToInvariantString()},{p.Y.ToInvariantString()}");

            var polygon = new XElement("polygon".SvgName());
            polygon.AddAttribute("points", pointsString);
            polygon.SafeAddIdAttribute(id);
            return polygon;
        }

        public static XElement AddPolygon(this XElement element, IEnumerable<SvgPoint> points, string id = null)
        {
            var polygon = Polygon(points, id);
            element.Add(polygon);
            return polygon;
        }

        private static XElement SafeAddIdAttribute(this XElement element, string id)
        {
            if (id != null)
            {
                element.AddAttribute("id", id);
            }

            return element;
        }

        private static string ToInvariantString(this double value) =>
            value.ToString(CultureInfo.InvariantCulture);
    }
}
