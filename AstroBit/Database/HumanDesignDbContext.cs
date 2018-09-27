#if NETCOREAPP2_0
using Microsoft.EntityFrameworkCore;
#elif NET45
using System.Data.Entity;
#endif

namespace AstroBit.Database
{
    public class HumanDesignDbContext : DbContext
    {
        private const string connectionString = "Data Source=HumanDesign.db";

        public DbSet<EfHumanDesignGateEntry> Gates { get; set; }

#if NET45
        public HumanDesignDbContext()
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
