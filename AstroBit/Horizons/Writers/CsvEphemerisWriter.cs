using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace AstroBit.Horizons.Writers
{
    public class CsvEphemerisWriter : IEphemerisWriter
    {
        private readonly string filePath;

        public CsvEphemerisWriter(string filePath)
        {
            this.filePath = filePath;
        }

        public void Write(IEnumerable<EphemerisEntry> ephemerisEntries)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            StringBuilder header = new StringBuilder();
            header.AppendLine("Date               Sun          Moon       Mercury      Venus        Mars         Jupiter      Saturn        Uranus      Neptune      Pluto        Chiron       North Node   Black Moon Lilith");

            File.WriteAllText(filePath, header.ToString());

            StringBuilder sb = new StringBuilder();

            var entries = ephemerisEntries.OrderBy(x => x.Date);
            foreach (var entry in entries)
            {
                sb.Append(entry.Date.ToString("yyyy-MM-dd HH:mm"));
                sb.Append($"   {FormatDegree(entry.Sun)}");
                sb.Append($"   {FormatDegree(entry.Moon)}");
                sb.Append($"   {FormatDegree(entry.Mercury)}{FormatRetrograde(entry.MercuryRetrograde)}");
                sb.Append($"   {FormatDegree(entry.Venus)}{FormatRetrograde(entry.VenusRetrograde)}");
                sb.Append($"   {FormatDegree(entry.Mars)}{FormatRetrograde(entry.MarsRetrograde)}");
                sb.Append($"   {FormatDegree(entry.Jupiter)}{FormatRetrograde(entry.JupiterRetrograde)}");
                sb.Append($"   {FormatDegree(entry.Saturn)}{FormatRetrograde(entry.SaturnRetrograde)}");
                sb.Append($"   {FormatDegree(entry.Uranus)}{FormatRetrograde(entry.UranusRetrograde)}");
                sb.Append($"   {FormatDegree(entry.Neptune)}{FormatRetrograde(entry.NeptuneRetrograde)}");
                sb.Append($"   {FormatDegree(entry.Pluto)}{FormatRetrograde(entry.PlutoRetrograde)}");
                sb.Append($"   {FormatDegree(entry.Chiron)}{FormatRetrograde(false)}");
                sb.Append($"   {FormatDegree(entry.NorthNode)}{FormatRetrograde(false)}");
                sb.Append($"   {FormatDegree(entry.BlackMoonLilith)}{FormatRetrograde(false)}");
                sb.AppendLine();
            }

            File.AppendAllText(filePath, sb.ToString());

            Thread.CurrentThread.CurrentCulture = currentCulture;
        }

        private static string FormatDegree(double degree) =>
            string.Format("{0,9:0.00000}", degree);

        private static string FormatRetrograde(bool isRetrograde) =>
            isRetrograde
            ? "R"
            : " ";
    }
}
