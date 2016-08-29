
namespace TestApp
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var routes = new List<Route>
            {
                new Route { StartPoint = "Мельбурн", EndPoint="Кельн" },
                new Route { StartPoint = "Москва", EndPoint="Париж" },
                new Route { StartPoint = "Париж", EndPoint="Берлин" },
                new Route { StartPoint = "Кельн", EndPoint="Москва" },
            };
            Console.WriteLine($"Current routes: {routes.ToText()}");

            var sortedRoutes = Helper.SortRoutes(routes);

            Console.WriteLine($"Sorted routes: {routes.ToText()}");

            Console.ReadKey();
        }
    }
}
