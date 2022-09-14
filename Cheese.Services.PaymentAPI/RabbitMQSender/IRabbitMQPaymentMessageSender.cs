using Cheese.MessageBus;

namespace Cheese.Services.PaymentAPI.RabbitMQSender
{
    public interface IRabbitMQPaymentMessageSender
    {
        void SendMessage(BaseMessage message);
    }
}
