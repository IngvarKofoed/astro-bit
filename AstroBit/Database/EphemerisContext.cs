using Microsoft.EntityFrameworkCore;

namespace AstroBit.Database
{
    public class EphemerisContext : DbContext
    {
        public DbSet<EfEphemerisEntry> Ephemeris { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Ephemeris.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
