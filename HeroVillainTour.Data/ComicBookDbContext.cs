using HeroVillainTour.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace HeroVillainTour.Data
{
    public class ComicBookDbContext : DbContext, IComicBookDbContext
    {
        public ComicBookDbContext(DbContextOptions<ComicBookDbContext> options) : base(options)
        {
        }

        public ComicBookDbContext Instance => this;

        public virtual DbSet<HeroDomainModel> Heros { get; set; }
        public virtual DbSet<VillainDomainModel> Villains { get; set; }
    }


}
