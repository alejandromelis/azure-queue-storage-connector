using AzureQueueStorageConnector.Services.Contracts;
using AzureQueueStorageConnector.Services.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace AzureQueueStorageConnector.Services
{
    public class QueueStorageConnector : IQueueStorageConnector
    {
        private readonly IQueueStorageConnectorConfiguration _queueStorageConnectorConfiguration;
        private const string ConnectionString = "DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1}";

        public QueueStorageConnector(IQueueStorageConnectorConfiguration queueStorageConnectorConfiguration)
        {
            _queueStorageConnectorConfiguration = queueStorageConnectorConfiguration;
        }

        public MessageDescription ReadMessage(string triggerState)
        {
            var queue = GetCloudQueue();
            var message = queue.GetMessage();
            var messageDescription = new MessageDescription
            {
                ContentData = message.AsString,
                ContentTransferEncoding = "none",
                ContentType = "text/plain"
            };
            return messageDescription;
        }


        public void SendMessage(MessageDescription messageDescription)
        {
            var queue = GetCloudQueue();

            var message = new CloudQueueMessage(messageDescription.ContentData);
            queue.AddMessage(message);            
        }

        private CloudQueue GetCloudQueue()
        {
            var connectionString = string.Format(ConnectionString, _queueStorageConnectorConfiguration.StorageAccountName, _queueStorageConnectorConfiguration.StorageAccountKey);
            var storageAccount = CloudStorageAccount.Parse(connectionString);

            var queueClient = storageAccount.CreateCloudQueueClient();
            var queue = queueClient.GetQueueReference(_queueStorageConnectorConfiguration.QueueName);
            return queue;
        }
    }
}
