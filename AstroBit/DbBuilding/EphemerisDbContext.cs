using Microsoft.EntityFrameworkCore;

namespace AstroBit.DbBuilding
{
    public class EphemerisDbContext : DbContext
    {
        public DbSet<EphemerisEntry> Ephemeris { get; set; }

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
