using Cheese.MessageBus;

namespace Cheese.Services.ShoppingCartAPI.RabbitMQSender
{
    public interface IRabbitMQCartMessageSender
    {
        void SendMessage(BaseMessage message, String queueName);
    }
}
