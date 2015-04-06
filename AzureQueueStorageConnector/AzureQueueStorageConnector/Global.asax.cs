using System.Web;
using System.Web.Http;

namespace AzureQueueStorageConnector
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            DependencyInjectionConfig.Register();
        }
    }
}
