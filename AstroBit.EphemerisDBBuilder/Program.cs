using System;
using System.Text;
using System.Linq;
using AstroBit.EphemerisDBBuilder.AstroCom;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Net;
using System.Collections.Generic;

namespace AstroBit.EphemerisDBBuilder
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            File.WriteAllText("db.csv", "");

            var lastEntry = last1899Entry;
            for (int year = 1900; year < 2100; year++)
            {
                Console.Write($"{year}: Fetching. ");
                var pdf = FetchPdf(year);
                File.WriteAllBytes($"{year}.pdf", pdf);
                var text = ExtractTextFromPdf(pdf);

                Console.Write("Parsing. ");
                var parser = new Parser(text, lastEntry);
                var entires = parser.Parse(year).ToArray();

                Console.Write("Writing. ");
                List<string> lines = new List<string>();
                foreach (var entry in entires)
                {
                    lines.Add(entry.ToString());
                }

                File.AppendAllLines("db.csv", lines);

                Console.WriteLine("Done!");

                lastEntry = entires.Last();
            }

            //var text = ExtractTextFromPdf(@"c:\Private\ae_1900.pdf");

            //var parser = new Parser(text, last1899Entry);
            //var entires = parser.Parse(1900).ToArray();

            
            //StringBuilder sb = new StringBuilder();
            //foreach (var entry in entires)
            //{
            //    sb.AppendLine(entry.ToString());
            //    // Console.WriteLine(entry);
            //}

            
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
