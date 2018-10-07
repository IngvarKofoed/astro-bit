#if NETCOREAPP2_0
using Microsoft.EntityFrameworkCore;
#elif NET45
using System.Data.Entity;
using System.Data.SQLite;
#endif

namespace AstroBit.Database
{
    public class EphemerisDbContext : DbContext
    {
        public DbSet<EfEphemerisEntry> Ephemeris { get; set; }

#if NET45
        public EphemerisDbContext()
            : base(new SQLiteConnection("Data Source=|DataDirectory|Ephemeris.db"), true)
        {
        }
#endif

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
