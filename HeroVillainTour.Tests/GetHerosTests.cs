using System.Collections.Generic;
using System.Linq;
using HeroVillainTour.ApiModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeroVillainTour.Tests
{
    [TestClass]
    public class GetHerosTests : TestingBase
    {
        protected List<HeroApiModel> Results;

        public override void Act()
        {
            Results = _sut.GetHeros();
        }

        [TestMethod]
        public void SupermanIsReturned()
        {
            Assert.IsTrue(Results.Any(x => x.Name == "Superman"));
        }

        [TestMethod]
        public void BatmanIsReturned()
        {
            Assert.IsTrue(Results.Any(x => x.Name == "Batman"));
        }

    }
}
