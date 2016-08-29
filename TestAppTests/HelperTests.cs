
namespace TestApp.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using TestApp;

    [TestClass()]
    public class HelperTests
    {
        [TestMethod()]
        public void SortRoutesTest()
        {
            var routes = new List<Route>
            {
                new Route { StartPoint = "МЕЛЬБУРН", EndPoint="Кельн" },
                new Route { StartPoint = "Москва", EndPoint="ПАРИЖ" },
                new Route { StartPoint = "Кельн", EndPoint="Москва" }
            };

            var sortedRoutes = Helper.SortRoutes(routes);

            Assert.AreEqual(routes[routes.Count - 1].StartPoint, "Москва");
            Assert.AreEqual(routes[routes.Count - 1].EndPoint, "ПАРИЖ");
        }
    }
}