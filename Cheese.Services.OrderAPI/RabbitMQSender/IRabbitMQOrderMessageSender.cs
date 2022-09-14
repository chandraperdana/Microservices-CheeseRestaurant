using Cheese.MessageBus;

namespace Cheese.Services.OrderAPI.RabbitMQSender
{
    public interface IRabbitMQOrderMessageSender
    {
        void SendMessage(BaseMessage message, String queueName);
    }
}
