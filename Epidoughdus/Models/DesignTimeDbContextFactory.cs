using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Epidoughdus.Models
{
    public class EpidoughdusContextFactory : IDesignTimeDbContextFactory<EpidoughdusContext>
    {

        EpidoughdusContext IDesignTimeDbContextFactory<EpidoughdusContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<EpidoughdusContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new EpidoughdusContext(builder.Options);
        }
    }
}