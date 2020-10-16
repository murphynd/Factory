using Microsoft.EntityFrameworkCore;
namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Patient> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<License> Licenses { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}