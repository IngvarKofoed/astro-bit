using System.Xml.Linq;

namespace AstroBit.Xml
{
    public static class XElementExtensions
    {
        public static XElement AddAttribute(this XElement element, string name, object value)
        {
            element.Add(new XAttribute(name, value));
            return element;
        }
    }
}
