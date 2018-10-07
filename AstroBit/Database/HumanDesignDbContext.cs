#if NETCOREAPP2_0
using Microsoft.EntityFrameworkCore;
#elif NET45
using System.Data.Entity;
using System.Data.SQLite;
#endif

namespace AstroBit.Database
{
    public class HumanDesignDbContext : DbContext
    {
        public DbSet<EfHumanDesignGateEntry> Gates { get; set; }

#if NET45
        public HumanDesignDbContext()
            : base(new SQLiteConnection("Data Source=|DataDirectory|HumanDesign.db"), true)
        {
        }
#endif

#if NETCOREAPP2_0
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=HumanDesign.db");
            }
        }
#endif

#if NETCOREAPP2_0
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<EfHumanDesignGateEntry>()
                .HasKey(x => new { x.GateNumber, x.LineNumber });
        }
#elif NET45
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<EfHumanDesignGateEntry>()
                .HasKey(x => new { x.GateNumber, x.LineNumber });
        }
#endif
    }
}
