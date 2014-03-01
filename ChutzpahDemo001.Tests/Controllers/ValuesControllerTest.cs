namespace ChutzpahDemo001.Tests.Controllers
{
    using ChutzpahDemo001.Controllers;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LevenshteinControllerTest
    {
        [TestMethod]
        public void GetLevenshtein()
        {
            // Arrange
            var controller = new LevenshteinController();

            Assert.AreEqual(1, controller.Get("David", "Davvid"));
            Assert.AreEqual(2, controller.Get("David", "Divad"));
            Assert.AreEqual(1, controller.Get("David", "Dvid"));
            Assert.AreEqual(2, controller.Get("Katrine", "Ktrne"));
        }
    }
}
