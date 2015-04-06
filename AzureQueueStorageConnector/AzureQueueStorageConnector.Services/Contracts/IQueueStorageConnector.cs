using AzureQueueStorageConnector.Services.Models;

namespace AzureQueueStorageConnector.Services.Contracts
{
    public interface IQueueStorageConnector
    {
        MessageDescription ReadMessage(string triggerState);
        void SendMessage(MessageDescription messageDescription);
    }
}