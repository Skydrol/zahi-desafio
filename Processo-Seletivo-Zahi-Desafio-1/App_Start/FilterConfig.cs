using System.Web;
using System.Web.Mvc;

namespace Processo_Seletivo_Zahi_Desafio_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
