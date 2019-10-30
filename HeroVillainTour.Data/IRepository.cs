using System.Collections.Generic;
using HeroVillainTour.DomainModels;

namespace HeroVillainTour.Data
{
    public interface IRepository
    {
        IEnumerable<HeroDomainModel> GetHeros();
        HeroDomainModel GetHeroByID(int id);
        void InsertHero(HeroDomainModel hero);
        void DeleteHero(int id);
        void UpdateHero(HeroDomainModel hero);

        IEnumerable<VillainDomainModel> GetVillains();
        VillainDomainModel GetVillainByID(int id);
        void InsertVillain(VillainDomainModel villain);
        void DeleteVillain(int id);
        void UpdateVillain(VillainDomainModel villain);

        void Save();

    }
}