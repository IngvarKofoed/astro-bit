using AstroBit.HumanDesign.Txt;
using System.Globalization;
using System.Text;

namespace AstroBit.IChing.TableGeneration
{
    public static class TableGenerator
    {
        public static string Generate()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("public static IReadOnlyList<Hexagram> Hexagrams = new List<Hexagram>");
            result.AppendLine("{");
            foreach (var gate in GateParser.Parse())
            {
                // new Hexagram(1, "NAME", Trigram.Force, Trigram.Force, new [] { new HexagramLine(1, 0.0, 0.0), new HexagramLine(1, 0.0, 0.0), new HexagramLine(1, 0.0, 0.0), new HexagramLine(1, 0.0, 0.0), new HexagramLine(1, 0.0, 0.0), new HexagramLine(1, 0.0, 0.0) } )

                StringBuilder lineBuilder = new StringBuilder();
                foreach (var line in gate.Lines)
                {
                    if (lineBuilder.Length != 0)
                    {
                        lineBuilder.Append(", ");
                    }
                    lineBuilder.Append($"new HexagramLine({line.Number}, {line.StartDegree.ToString(CultureInfo.InvariantCulture)}, {line.EndDegree.ToString(CultureInfo.InvariantCulture)})");
                }

                result.AppendLine($"    new Hexagram({gate.Number}, \"NAME\", Trigram.Force, Trigram.Force, new [] {{ {lineBuilder} }} ),");
                //var lines = gate.Lines.Aggregate("", (a, l) => a == "" ? $"{l.EndDegree.ToString(CultureInfo.InvariantCulture)}" : $"{a}, {l.EndDegree.ToString(CultureInfo.InvariantCulture)}");
                //sb.AppendLine($"hexagrams.Add({gate.Number}, new[] {{ {lines} }});");
                //sb.AppendLine($"{{ {gate.Number}, new[] {{ {lines} }} }},");
            }
            result.AppendLine("};");

            return result.ToString();
        }
    }
}
