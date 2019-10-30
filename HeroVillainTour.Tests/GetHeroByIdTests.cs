using HeroVillainTour.ApiModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeroVillainTour.Tests
{
    [TestClass]
    public class GetHeroByIdTests : TestingBase
    {
        protected HeroApiModel Results;

        public override void Act()
        {
            Results = _sut.GetHeros(1);
        }

        [TestMethod]
        public void SupermanIsReturned()
        {
            Assert.AreEqual("Superman", Results.Name);
        }
    }
}
