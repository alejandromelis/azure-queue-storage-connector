using AzureQueueStorageConnector.Services.Models;

namespace AzureQueueStorageConnector.Services.Contracts
{
    public interface IQueueStorageConnector
    {
        MessageDescription ReadMessage();
        void SendMessage(MessageDescription messageDescription);
    }
}