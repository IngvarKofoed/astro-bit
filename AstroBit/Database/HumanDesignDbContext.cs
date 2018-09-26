using Microsoft.EntityFrameworkCore;

namespace AstroBit.Database
{
    public class HumanDesignDbContext : DbContext
    {
        public DbSet<EfHumanDesignGateEntry> Gates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=HumanDesign.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<EfHumanDesignGateEntry>()
                .HasKey(x => new { x.GateNumber, x.LineNumber });
        }
    }
}
