using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using AstroBit.Database;
using AstroBit.EphemerisDBBuilder.AstroCom;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace AstroBit.EphemerisDBBuilder
{
    class Program
    {
        private static readonly bool useCachedPdfs = true;
        private static readonly string outputCsvFilename = "Ephemeris.csv";
        private static readonly bool resetDatabase = true;

        
        static void Main(string[] args)
        {
            ResetCsvFile();

            using (var context = new EphemerisDbContext())
            {
                if (resetDatabase)
                { 
                    context.Database.EnsureDeleted();
                }
                context.Database.EnsureCreated();

                var lastEntry = last1899Entry;
                for (int year = 1900; year < 2100; year++)
                {
                    byte[] pdf = null;
                    if (useCachedPdfs)
                    {
                        Console.Write($"{year}: Loading. ");
                        pdf = LoadPdf(year);
                    }
                    else
                    {
                        Console.Write($"{year}: Fetching. ");
                        pdf = FetchPdf(year);
                        Console.Write($"{year}: Saving. ");
                        SavePdf(year, pdf);
                    }

                    Console.Write($"{year}: Converting. ");
                    var text = ExtractTextFromPdf(pdf);

                    Console.Write("Parsing. ");
                    var parser = new Parser(text, lastEntry);
                    var entires = parser.Parse(year).ToArray();

                    Console.Write("Saving DB. ");
                    SaveToDb(context,  entires);                    

                    Console.Write("Writing CSV. ");
                    WriteToCsv(entires);

                    Console.WriteLine("Done!");

                    lastEntry = entires.Last();
                }
            }
        }        

        private static byte[] FetchPdf(int year)
        {
            var century = 0;
            if (year >= 1900 && year <= 1999)
            {
                century = 1900;
            }
            else if (year >= 2000 && year <= 2099)
            {
                century = 2000;
            }
            else if (year >= 2100 && year <= 2199)
            {
                century = 2100;
            }
            else
            {
                throw new NotImplementedException();
            }

            using (var client = new WebClient())
            {
                return client.DownloadData($"https://www.astro.com/swisseph/ae/{century}/ae_{year}.pdf");
            }
        }

        private static byte[] LoadPdf(int year) =>
            File.ReadAllBytes(GetPdfFileName(year));

        private static void SavePdf(int year, byte[] pdf) =>
            File.WriteAllBytes(GetPdfFileName(year), pdf);

        private static string GetPdfFileName(int year) =>
            $"{year}.pdf";


        private static void SaveToDb(EphemerisDbContext context, IEnumerable<EphemerisEntry> entries)
        {
            foreach (var entry in entries)
            {
                context.Ephemeris.Add(new EfEphemerisEntry
                {
                    Id = entry.Date.Ticks,
                    Date = entry.Date,
                    SiderealTime = entry.SiderealTime,
                    Sun = entry.Sun.AbsolutePosition,
                    Moon = entry.Moon.AbsolutePosition,
                    Mercury = entry.Mercury.AbsolutePosition,
                    MercuryRetrograde = entry.Mercury.Direction == PlanetDirection.Retrograde,
                    Venus = entry.Venus.AbsolutePosition,
                    VenusRetrograde = entry.Venus.Direction == PlanetDirection.Retrograde,
                    Mars = entry.Mars.AbsolutePosition,
                    MarsRetrograde = entry.Mars.Direction == PlanetDirection.Retrograde,
                    Jupiter = entry.Jupiter.AbsolutePosition,
                    JupiterRetrograde = entry.Jupiter.Direction == PlanetDirection.Retrograde,
                    Saturn = entry.Saturn.AbsolutePosition,
                    SaturnRetrograde = entry.Saturn.Direction == PlanetDirection.Retrograde,
                    Uranus = entry.Uranus.AbsolutePosition,
                    UranusRetrograde = entry.Uranus.Direction == PlanetDirection.Retrograde,
                    Neptune = entry.Neptune.AbsolutePosition,
                    NeptuneRetrograde = entry.Neptune.Direction == PlanetDirection.Retrograde,
                    Pluto = entry.Pluto.AbsolutePosition,
                    PlutoRetrograde = entry.Pluto.Direction == PlanetDirection.Retrograde,
                    TrueNode = entry.TrueNode.AbsolutePosition,
                    TrueNodeRetrograde = entry.TrueNode.Direction == PlanetDirection.Retrograde,
                    MeanNode = entry.MeanNone.AbsolutePosition,
                    MeanNodeRetrograde = entry.MeanNone.Direction == PlanetDirection.Retrograde,
                    BlackMoonLilith = entry.BlackMoonLilith.AbsolutePosition,
                    BlackMoonLilithRetrograde = entry.BlackMoonLilith.Direction == PlanetDirection.Retrograde,
                    Chiron = entry.Chiron.AbsolutePosition,
                    ChironRetrograde = entry.Chiron.Direction == PlanetDirection.Retrograde
                });
            }

            context.SaveChanges();
        }

        private static void ResetCsvFile() =>
            File.WriteAllText(outputCsvFilename, "");

        private static void WriteToCsv(IEnumerable<EphemerisEntry> entries)
        {
            List<string> lines = new List<string>();
            foreach (var entry in entries)
            {
                lines.Add(entry.ToString());
            }

            File.AppendAllLines(outputCsvFilename, lines);
        }

        private static string ExtractTextFromPdf(string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }

        private static string ExtractTextFromPdf(byte[] data)
        {
            using (PdfReader reader = new PdfReader(data))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }

        private static EphemerisEntry last1899Entry = new EphemerisEntry(
            new DateTime(1976, 12, 31, 0, 0, 0, DateTimeKind.Utc),
            6 + (38 / 60.0) + (11 / 3600.0),
            new Planet(PlanetType.Sun, Zodiac.Capricorn.GetAbsoluteDegrees(9, 8, 1), PlanetDirection.Direct),
            new Planet(PlanetType.Moon, Zodiac.Sagittarius.GetAbsoluteDegrees(18, 16), PlanetDirection.Direct),
            new Planet(PlanetType.Mercury, Zodiac.Sagittarius.GetAbsoluteDegrees(17, 44), PlanetDirection.Direct),
            new Planet(PlanetType.Venus, Zodiac.Aquarius.GetAbsoluteDegrees(5, 8), PlanetDirection.Direct),
            new Planet(PlanetType.Mars, Zodiac.Capricorn.GetAbsoluteDegrees(13, 6), PlanetDirection.Direct),
            new Planet(PlanetType.Jupiter, Zodiac.Sagittarius.GetAbsoluteDegrees(0, 56), PlanetDirection.Direct),
            new Planet(PlanetType.Saturn, Zodiac.Sagittarius.GetAbsoluteDegrees(27, 36), PlanetDirection.Direct),
            new Planet(PlanetType.Uranus, Zodiac.Sagittarius.GetAbsoluteDegrees(10, 5), PlanetDirection.Direct),
            new Planet(PlanetType.Neptune, Zodiac.Gemini.GetAbsoluteDegrees(25, 15), PlanetDirection.Retrograde),
            new Planet(PlanetType.Pluto, Zodiac.Gemini.GetAbsoluteDegrees(15, 16), PlanetDirection.Retrograde),
            new Planet(PlanetType.TrueNode, Zodiac.Sagittarius.GetAbsoluteDegrees(20, 16), PlanetDirection.Retrograde),
            new Planet(PlanetType.MeanNode, Zodiac.Sagittarius.GetAbsoluteDegrees(19, 13), PlanetDirection.Direct),
            new Planet(PlanetType.BlackMoonLilith, Zodiac.Virgo.GetAbsoluteDegrees(4, 14), PlanetDirection.Direct),
            new Planet(PlanetType.Chiron, Zodiac.Sagittarius.GetAbsoluteDegrees(18, 47), PlanetDirection.Direct)
        );
    }
}
