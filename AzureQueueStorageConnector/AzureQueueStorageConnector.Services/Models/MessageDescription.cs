namespace AzureQueueStorageConnector.Services.Models
{
    /// <summary>
    /// Class that represent a Queue Storage Message
    /// </summary>
    public class MessageDescription
    {
        /// <summary>
        /// Content of the message
        /// </summary>
        public string ContentData { get; set; }
        /// <summary>
        /// Content Transfer Encoding of the Message. ("none"|"base64")
        /// </summary>
        public string ContentTransferEncoding { get; set; }
        /// <summary>
        /// Content type of the message content
        /// </summary>
        public string ContentType { get; set; }

    }
}