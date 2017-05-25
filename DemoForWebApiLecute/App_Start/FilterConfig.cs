using Newtonsoft.Json.Serialization;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DemoForWebApiLecute
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            //xml.UseXmlSerializer = true;

            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
