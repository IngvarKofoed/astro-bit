#if NETCOREAPP2_0
using Microsoft.EntityFrameworkCore;
#elif NET45
using System.Data.Entity;
#endif

namespace AstroBit.Database
{
    public class EphemerisDbContext : DbContext
    {
        private const string connectionString = "Data Source=Ephemeris.db";

        public DbSet<EfEphemerisEntry> Ephemeris { get; set; }

#if NET45
        public EphemerisDbContext()
            : base(connectionString)
        {
        }
#endif

#if NETCOREAPP2_0
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(connectionString);
            }
        }
#endif
    }
}
