using System.Web;
using System.Web.Mvc;

namespace TranNguyenThaoUyen_2011068936_BigSchool_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
