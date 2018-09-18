using AstroBit.DbBuilding;
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

            Console.WriteLine("ALL DONE!!!");
            Console.ReadKey();
        }
    }
}
