using System.Collections.Generic;
using System.Linq;
using HeroVillainTour.BusinessLayer;
using HeroVillainTour.Core;
using HeroVillainTour.Data;
using HeroVillainTour.DomainModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HeroVillainTour.Tests
{
    [TestClass]
    public abstract class TestingBase : AAA
    {

        public Mock<IRepository> _repository;
        public IHeroService _sut;

        public override void Arrange()
        {
            var heros = new List<HeroDomainModel>()
            {
                new HeroDomainModel(){Id=1, Name = "Superman"},
                new HeroDomainModel(){Id=2, Name = "Batman"}
            };

            _repository = new Mock<IRepository>().SetupAllProperties();
            _repository.Setup(x => x.GetHeros()).Returns(heros).Verifiable();
            _repository.Setup(x => x.GetHeroByID(1)).Returns(heros.First(x => x.Id == 1)).Verifiable();
            _repository.Setup(x => x.GetHeroByID(2)).Returns(heros.First(x => x.Id == 2)).Verifiable();

            _sut = new HeroService(_repository.Object);
        }
    }
}
