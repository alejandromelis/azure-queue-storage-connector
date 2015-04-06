using System.Configuration;
using AzureQueueStorageConnector.Services.Contracts;

namespace AzureQueueStorageConnector.Services.Services
{
    public class QueueStorageConnectorConfiguration : IQueueStorageConnectorConfiguration
    {
        public string StorageAccountName
        {
            get { return ConfigurationManager.AppSettings["StorageAccountName"]; }
        }

        public string StorageAccountKey
        {
            get { return ConfigurationManager.AppSettings["StorageAccountKey"]; }
        }

        public string QueueName
        {
            get { return ConfigurationManager.AppSettings["QueueName"]; ; }
        }
    }
}