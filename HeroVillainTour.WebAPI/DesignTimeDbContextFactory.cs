using System.IO;
using HeroVillainTour.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HeroVillainTour.WebAPI
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ComicBookDbContext>
    {
        public ComicBookDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ComicBookDbContext>();

            var connectionString = configuration.GetConnectionString("ConnectionString");

            builder.UseSqlServer(connectionString);

            return new ComicBookDbContext(builder.Options);
        }
    }
}