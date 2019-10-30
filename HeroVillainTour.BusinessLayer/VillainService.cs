using System.Collections.Generic;
using System.Linq;
using HeroVillainTour.ApiModels;
using HeroVillainTour.Core;
using HeroVillainTour.Data;
using HeroVillainTour.DomainModels;

namespace HeroVillainTour.BusinessLayer
{
    public class VillainService : IVillainService
    {
        private readonly IComicBookDbContext _repository;

        public VillainService(IComicBookDbContext repository)
        {
            _repository = repository;
        }

        public List<VillainApiModel> GetVillains()
        {
            return _repository.Instance.Villains.Select(hero => Convert(hero)).ToList();
        }

        public VillainApiModel GetVillains(int id)
        {
            return _repository.Instance.Villains.Where(x => x.Id == id).Select(hero => Convert(hero)).FirstOrDefault();
        }

        public List<VillainApiModel> GetVillains(string name)
        {
            return _repository.Instance.Villains.Where(x => x.Name == name).Select(hero => Convert(hero)).ToList();
        }

        public VillainApiModel Convert(VillainDomainModel hero)
        {
            return new VillainApiModel() {Name = hero.Name, Id = hero.Id};
        }

    }
}
