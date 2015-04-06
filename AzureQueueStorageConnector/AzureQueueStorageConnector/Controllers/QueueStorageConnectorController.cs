using System.Web.Http;
using AzureQueueStorageConnector.Services.Models;

namespace AzureQueueStorageConnector.Controllers
{
    /// <summary>
    /// Azure Queue Storage Connector API App
    /// </summary>
    public class QueueStorageConnectorController : ApiController
    {
        /// <summary>
        /// Message Available
        /// </summary>
        /// <remarks>
        /// Receive message from Azure Queue Storage
        /// </remarks>
        /// <param name="triggerState"></param>
        /// <returns></returns>
        [Route("api/queuestorageconnector/message")]
        [HttpGet]
        public MessageDescription GetMessage(string triggerState)
        {
            return new MessageDescription {  };
        }

        /// <summary>
        /// Send a message
        /// </summary>
        /// <remarks>
        /// Send a message to Azure Queue Storage
        /// </remarks>
        /// <param name="queueMessage">Required. This is the object of type
        ///  MessageDescription which is sent to the Azure Queue Storage.</param>
        [Route("api/queuestorageconnector/message")]
        [HttpPost]
        public void SendMessage([FromBody]MessageDescription queueMessage)
        {
        }
    }
}
