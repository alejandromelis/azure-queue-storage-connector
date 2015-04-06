using AzureQueueStorageConnector.Services.Contracts;
using AzureQueueStorageConnector.Services.Models;

namespace AzureQueueStorageConnector.Services
{
    public class QueueStorageConnector : IQueueStorageConnector
    {
        private readonly IQueueStorageConnectorConfiguration _queueStorageConnectorConfiguration;

        public QueueStorageConnector(IQueueStorageConnectorConfiguration queueStorageConnectorConfiguration)
        {
            _queueStorageConnectorConfiguration = queueStorageConnectorConfiguration;
        }

        public MessageDescription ReadMessage()
        {
            return new MessageDescription();
        }


        public void SendMessage(MessageDescription messageDescription)
        {
            
        }
    }
}
