using System.Web;
using System.Web.Mvc;

namespace Impact_Alaska_Mission_Tracking
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
