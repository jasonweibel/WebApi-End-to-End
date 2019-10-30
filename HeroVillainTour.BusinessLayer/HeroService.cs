using System.Collections.Generic;
using System.Linq;
using HeroVillainTour.ApiModels;
using HeroVillainTour.Core;
using HeroVillainTour.Data;
using HeroVillainTour.DomainModels;

namespace HeroVillainTour.BusinessLayer
{
    public class HeroService : IHeroService
    {
        private readonly IRepository _repository;

        public HeroService(IRepository repository)
        {
            _repository = repository;
        }

        public List<HeroApiModel> GetHeros()
        {
            var data = _repository.GetHeros().ToList();
            var results = new List<HeroApiModel>();
            data.ForEach(x => results.Add(Convert(x)));
            return results;
        }

        public HeroApiModel GetHeros(int id)
        {
            var data = _repository.GetHeroByID(id);
            var results = Convert(data);
            return results;
        }

        public List<HeroApiModel> GetHeros(string name)
        {
            var data = _repository.GetHeros().Where(x => x.Name == name).ToList();
            var results = new List<HeroApiModel>();
            data.ForEach(x => results.Add(Convert(x)));
            return results;
        }

        public void AddHero(HeroApiModel hero)
        {
            var data = Convert(hero);
            _repository.InsertHero(data);
            _repository.Save();
        }

        public HeroApiModel Convert(HeroDomainModel hero)
        {
            return hero == null ? new HeroApiModel() : new HeroApiModel() {Name = hero.Name, Id = hero.Id};
        }

        public HeroDomainModel Convert(HeroApiModel  hero)
        {
            return hero == null ? new HeroDomainModel() : new HeroDomainModel() { Name = hero.Name, Id = hero.Id };
        }

    }
}
