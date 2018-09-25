using AstroBit.Horizons.DbBuilding;
using AstroBit.Horizons.Writers;
using System;
using System.Linq;

namespace AstroBit.EphemerisDBUpdator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EphemerisDbContext())
            {
                var ephemeris = context.Ephemeris.ToList();

                int index1 = 0;
                while (true)
                {
                    var entry1 = ephemeris[index1];

                    int index2 = index1 + 1;
                    while (index2 < ephemeris.Count && (ephemeris[index2].Date - entry1.Date).TotalDays < 1)
                    {
                        index2++;
                    }

                    if (index2 >= ephemeris.Count)
                    {
                        break;
                    }

                    var entry2 = ephemeris[index2];

                    if (entry1.Venus > entry2.Venus)
                    {
                        for (int i = index1; i<= index2; i++)
                        {
                            ephemeris[i].VenusRetrograde = true;
                        }
                    }

                    index1 = index2;
                }


                //for (int i = 1; i < ephemeris.Count; i++)
                //{
                //    var entry1 = ephemeris[i - 1];
                //    var entry2 = ephemeris[i];

                //    entry1.MercuryRetrograde = entry1.Mercury > entry2.Mercury;
                //    entry1.VenusRetrograde = entry1.Venus > entry2.Venus;
                //    entry1.MarsRetrograde = entry1.Mars > entry2.Mars;
                //    entry1.JupiterRetrograde = entry1.Jupiter > entry2.Jupiter;
                //    entry1.SaturnRetrograde = entry1.Saturn > entry2.Saturn;
                //    entry1.UranusRetrograde = entry1.Uranus > entry2.Uranus;
                //    entry1.NeptuneRetrograde = entry1.Neptune > entry2.Neptune;
                //    entry1.PlutoRetrograde = entry1.Pluto > entry2.Pluto;
                //}

                var csvWriter = new CsvEphemerisWriter("Ephemeris.csv");
                csvWriter.Write(ephemeris.Select(x => x.ToEphemerisEntry()));
            }

            Console.WriteLine("ALL DONE!!!");
            Console.ReadKey();
        }

        private static void FetchHorizonsData()
        {
            using (var context = new EphemerisDbContext())
            {
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();
                for (int year = 2015; year <= 2020; year++)
                {
                    int count = context.Ephemeris.Where(x => x.Date.Year == year).Count();
                    Console.WriteLine($"{year}: Entires count = {count}");
                }
            }


            SqliteEphemerisFetcher fetcher = new SqliteEphemerisFetcher();
            //fetcher.FetchRange(2018, 2020);
        }
    }
}
