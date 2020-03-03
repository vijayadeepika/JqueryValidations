using System.Web;
using System.Web.Mvc;

namespace Task1_clientsidevalidations
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
