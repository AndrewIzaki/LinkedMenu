using ingredient.Models;
using Microsoft.EntityFrameworkCore;
using product.Models;

namespace mysqlefcore
{
  public class ProductContext : DbContext
  {
    public DbSet<Product> product { get; set; }

    public DbSet<Ingredient> ingredient { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=LinkedMenu;user=root;password=senha123");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Product>(entity =>
      {
        entity.HasKey(e => e.id);
        entity.Property(e => e.name).IsRequired();
      });

      modelBuilder.Entity<Ingredient>(entity =>
      {
        entity.HasKey(e => e.id);
        entity.Property(e => e.name).IsRequired();
        entity.HasOne(d => d.Product)
          .WithMany(p => p.Ingredients);
      });
    }
  }
}