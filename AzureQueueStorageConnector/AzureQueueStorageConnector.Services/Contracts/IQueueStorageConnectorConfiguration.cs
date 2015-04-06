namespace AzureQueueStorageConnector.Services.Contracts
{
    public interface IQueueStorageConnectorConfiguration
    {
        string StorageAccountName  { get; }
        string StorageAccountKey { get; }
        string QueueName { get; }
    }
}