using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeroVillainTour.Tests
{
    [TestClass]
    public abstract class AAA
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void MainSetup()
        {
            Arrange();
            Act();
        }

        [TestCleanup]
        public void MainTeardown()
        {
            CleanUp();
        }

        public abstract void Arrange();
        public abstract void Act();

        public virtual void CleanUp() { }
    }
}
