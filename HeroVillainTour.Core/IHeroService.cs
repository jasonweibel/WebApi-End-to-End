using HeroVillainTour.ApiModels;
using System.Collections.Generic;

namespace HeroVillainTour.Core
{
    public interface IHeroService
    {
        List<HeroApiModel> GetHeros();
        HeroApiModel GetHeros(int id);
        List<HeroApiModel> GetHeros(string name);
        void AddHero(HeroApiModel hero);
    }
}