using Microsoft.EntityFrameworkCore;
using ReyRemerasApi.Models;
namespace ReyRemerasApi.Data
{
    public class ReyRemerasDbContext : DbContext
    {
        public ReyRemerasDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        DbSet<Category> Category { get; set; }
        DbSet<Color> Color { get; set; }
        DbSet<Fabric> Fabric { get; set; }
        DbSet<PriceSizeCategory> PriceSizeCategories { get;set; }
        DbSet<Product> Product { get;set; }
        DbSet<Size> Size { get; set; }
        DbSet<StockProduct> StockProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceSizeCategory>().HasNoKey();
            base.OnModelCreating(modelBuilder);
            
        }

    }
}
