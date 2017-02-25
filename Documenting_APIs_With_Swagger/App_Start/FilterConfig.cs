using System.Web;
using System.Web.Mvc;

namespace Documenting_APIs_With_Swagger
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
