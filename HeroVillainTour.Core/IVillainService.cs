using System.Collections.Generic;
using HeroVillainTour.ApiModels;

namespace HeroVillainTour.Core
{
    public interface IVillainService
    {
        List<VillainApiModel> GetVillains();
        VillainApiModel GetVillains(int id);
        List<VillainApiModel> GetVillains(string name);
    }
}