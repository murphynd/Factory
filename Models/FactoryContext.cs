using Microsoft.EntityFrameworkCore;
namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DoctorOfficeContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}