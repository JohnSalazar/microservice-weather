using Microsoft.EntityFrameworkCore;

namespace Cloudweather.Temperature.DataAccess;

public class TempDbContext : DbContext
{
  public TempDbContext() { }
  public TempDbContext(DbContextOptions options) : base(options) { }

  public DbSet<Temperature> Temperature { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    SnakeCaseIdentityTableNames(modelBuilder);
  }

  private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Temperature>(b => { b.ToTable("temperature"); });
  }
}
