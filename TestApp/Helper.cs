
namespace TestApp
{
    using System.Collections.Generic;
    using System.Linq;
    public static class Helper
    {
        public static IList<Route> SortRoutes(List<Route> routes)
        {
            return SortRoutes(routes, routes[0]);
        }
        private static IList<Route> SortRoutes(List<Route> routes, Route startRoute)
        {
            var currentRoute = routes.Where(p => p.StartPoint.ToUpperInvariant() == startRoute.EndPoint.ToUpperInvariant())
                                .FirstOrDefault();

            if (currentRoute == null)
                return routes;

            var index = routes.IndexOf(currentRoute);
            if (index >= 0)
                routes.RemoveAt(index);

            index = routes.IndexOf(startRoute);
            routes.Insert(index + 1, currentRoute);

            return SortRoutes(routes, currentRoute);
        }
    }
}
