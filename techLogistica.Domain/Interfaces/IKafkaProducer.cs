using System.Security.Cryptography;
using techLogistica.Domain.Entities;

namespace techLogistica.Domain.Interfaces
{
    public interface IKafkaProducer
    {
        Task<Message> ProduceAsync(string topic, string sender, string receiver, string content);
        Task<Message> ProduceAsyncWithRetry(string topic, string sender, string receiver, string content);
    }

}