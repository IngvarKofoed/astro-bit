#if NETCOREAPP2_0
using Microsoft.EntityFrameworkCore;
#elif NET45
using System.Data.Entity;
#endif

namespace AstroBit.Horizons.DbBuilding
{
    public class EphemerisDbContext : DbContext
    {
        public DbSet<EphemerisDbEntry> Ephemeris { get; set; }

#if NETCOREAPP2_0
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Ephemeris.db");
            }
        }
#endif
    }
}
