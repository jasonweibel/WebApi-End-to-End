using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HeroVillainTour.Data
{
    public class ComicBookDbContextFactory : IDesignTimeDbContextFactory<ComicBookDbContext>
    {
        private readonly DbContextOptions<ComicBookDbContext> _options;

        public ComicBookDbContextFactory(DbContextOptions<ComicBookDbContext> options)
        {
            _options = options;
        }

        public ComicBookDbContext CreateDbContext(string[] args)
        {
            return new ComicBookDbContext(_options);
        }
    }
}