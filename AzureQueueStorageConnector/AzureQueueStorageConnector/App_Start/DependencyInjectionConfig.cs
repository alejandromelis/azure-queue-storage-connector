using System.Web.Http;
using AzureQueueStorageConnector.Services;
using AzureQueueStorageConnector.Services.Contracts;
using AzureQueueStorageConnector.Services.Services;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace AzureQueueStorageConnector
{
    public class DependencyInjectionConfig
    {
        public static void Register()
        {
            var container = new Container();
            //container.AddRegistration();
            container.RegisterWebApiRequest<IQueueStorageConnector, QueueStorageConnector>();
            container.RegisterWebApiRequest<IQueueStorageConnectorConfiguration, QueueStorageConnectorConfiguration>();
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

    }
}