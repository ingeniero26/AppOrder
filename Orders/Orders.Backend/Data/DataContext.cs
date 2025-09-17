using Microsoft.EntityFrameworkCore;
using Orders.Shared.Entities;

namespace Orders.Backend.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public DbSet<BranchType> BranchTypes { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<DocumentType>().HasIndex(dt => dt.Name).IsUnique();
            modelBuilder.Entity<BranchType>().HasIndex(bt => bt.Name).IsUnique();
            modelBuilder.Entity<Brand>().HasIndex(b => b.Name).IsUnique();

        }

    }
}
