using System;
using System.Collections.Generic;
using System.Linq;
using HeroVillainTour.DomainModels;

namespace HeroVillainTour.Data
{
    public class Repository : IRepository
    {
        private IComicBookDbContext _context;

        public Repository(IComicBookDbContext context)
        {
            _context = context;
        }

        public IEnumerable<HeroDomainModel> GetHeros()
        {
            return _context.Instance.Heros;
        }

        public HeroDomainModel GetHeroByID(int id)
        {
            return _context.Instance.Heros.FirstOrDefault(x => x.Id == id);
        }

        public void InsertHero(HeroDomainModel hero)
        {
            _context.Instance.Heros.Add(hero);
        }

        public void DeleteHero(int id)
        {
            var hero = GetHeroByID(id);
            _context.Instance.Heros.Remove(hero);
        }

        public void UpdateHero(HeroDomainModel hero)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VillainDomainModel> GetVillains()
        {
            return _context.Instance.Villains;
        }

        public VillainDomainModel GetVillainByID(int id)
        {
            return _context.Instance.Villains.FirstOrDefault(x => x.Id == id);
        }

        public void InsertVillain(VillainDomainModel villain)
        {
            _context.Instance.Villains.Add(villain);
        }

        public void DeleteVillain(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateVillain(VillainDomainModel villain)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.Instance.SaveChanges();
        }
    }
}
