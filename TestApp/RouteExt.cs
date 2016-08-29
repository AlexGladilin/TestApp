
namespace TestApp
{
    using System.Collections.Generic;
    using System.Text;
    public static class RouteExt
    {
        public static string ToText(this List<Route> items)
        {
            if (items == null || items.Count == 0)
                return string.Empty;

            var str = new StringBuilder();
            foreach (var item in items)
                str.Append($"{item.StartPoint}->{item.EndPoint},");

            str.Remove(str.Length - 1, 1);

            return str.ToString();
        }
    }
}
