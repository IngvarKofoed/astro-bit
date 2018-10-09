using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Xml.Linq;

namespace AstroBit.SvgCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = XDocument.Load(@"c:\Users\mje\Desktop\HumanDesign.svg");

            InkScapeSvgCleaner.Clean(document);

            document.Save("HumanDesign.svg");

            var content = File.ReadAllText("HumanDesign.svg");

            var result = Regex.Replace(
                content,
                @"""#(?<name>[^#]+)#""", 
                x => $"{{{UnEscape(x.Groups.Where(g => g.Name == "name").Single().Value)}}}");

            File.WriteAllText("HumanDesign.svg", result);

            File.WriteAllLines("HumanDesign.svg", File.ReadAllLines("HumanDesign.svg").Skip(2).ToArray());
        }

        private static string UnEscape(string value) =>
            value.Replace("&gt;", ">");
    }
}
