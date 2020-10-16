using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace Factory.Models
{
  public class DesignTimeDbContextFactory
  {
    public class DoctorOfficeContextFactory : IDesignTimeDbContextFactory<DoctorOfficeContext>
    {

      DoctorOfficeContext IDesignTimeDbContextFactory<DoctorOfficeContext>.CreateDbContext(string[] args)
      {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<DoctorOfficeContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        builder.UseMySql(connectionString);

        return new DoctorOfficeContext(builder.Options);
      }
    }
  }
}