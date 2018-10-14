using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace AstroBit.SvgCleaner
{
    public static class InkScapeSvgCleaner
    {
        private static readonly string[] nameOfElementsToRemove = new [] { "image", "namedview", "metadata"};

        public static void Clean(XDocument document)
        {
            Clean(document.Root);
        }

        private static void Clean(XElement element)
        {
            if (nameOfElementsToRemove.Contains(element.Name.LocalName))
            {
                element.Remove();
                return;
            }

            if (element.Name.LocalName == "text")
            {
                var child = element.Elements().Where(x => x.Name.LocalName == "tspan").FirstOrDefault();
                if (child != null)
                {
                    element.Add(child.Value);
                    child.Remove();
                }
            }

            foreach (XAttribute attribute in element.Attributes().ToArray())
            {
                if (attribute.Name.NamespaceName != string.Empty || attribute.Name.LocalName == "xmlns")
                {
                    attribute.Remove();
                }
                else
                {
                    Clean(attribute);
                }
            }

            var elementId = element.Attribute("id").Value;
            if (elementId.StartsWith("gate_text_") || elementId.StartsWith("gate_background_"))
            {
                element.Add(new XAttribute("onClick", $"#_ => this.onGateClick({GetGateId(elementId)})#"));
            }

            foreach (var child in element.Elements().ToArray())
            {
                Clean(child);
            }
        }

        private static void Clean(XAttribute attribute)
        {
            var elementId = attribute.Parent.Attribute("id").Value;

            if (attribute.Name == "style")
            {
                if (elementId == "pattern_double_defined_1")
                {
                    attribute.Value = $"#this.designGatePathStyle#";
                }
                else if (elementId == "pattern_double_defined_2")
                {
                    attribute.Value = $"#this.personalityGatePathStyle#";
                }
                else if (elementId.StartsWith("gate_text_"))
                {
                    attribute.Value = $"#this.getGateTextStyle({GetGateId(elementId)})#";
                }
                else if (elementId.StartsWith("gate_background_"))
                {
                    attribute.Value = $"#this.getGateBackgroundStyle({GetGateId(elementId)})#";
                }
                else if (elementId.StartsWith("gatepath_"))
                {
                    attribute.Value = $"#this.getGatePathStyle({GetGateId(elementId)})#";
                }
                else if (elementId.StartsWith("white_"))
                {
                    attribute.Value = $"#this.whiteStyle#";
                }
                else 
                {
                    attribute.Value = "#this.basicStyle#";
                }                
            }
        }


        private static int GetGateId(string idString) =>
            int.Parse(idString.Split('_').Last());
    }
}
