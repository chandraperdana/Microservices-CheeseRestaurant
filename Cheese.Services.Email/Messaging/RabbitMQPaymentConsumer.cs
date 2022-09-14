
using Cheese.Services.Email.Messages;
using Cheese.Services.Email.Repository;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Threading.Channels;

namespace Cheese.Services.Email.Messaging
{
    public class RabbitMQPaymentConsumer : BackgroundService
    {
        //private const string ExchangeName = "PublishSubscribePaymentUpdate_Exchange";
        private const string ExchangeName = "DirectPaymentUpdate_Exchange";
        private const string PaymentEmailUpdateQueueName = "PaymentEmailUpdateQueueName";
        private IConnection _connection;
        private IModel _channel;
        private readonly EmailRepository emailRepo;
        string queueName = "";

        public RabbitMQPaymentConsumer(EmailRepository emailRepo)
        {
            this.emailRepo = emailRepo;
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            //_channel.ExchangeDeclare(ExchangeName, ExchangeType.Fanout);
            //queueName = _channel.QueueDeclare().QueueName;
            //_channel.QueueBind(queueName, ExchangeName, "");
            _channel.ExchangeDeclare(ExchangeName, ExchangeType.Direct);
            _channel.QueueDeclare(PaymentEmailUpdateQueueName, false, false, false, null);
            _channel.QueueBind(PaymentEmailUpdateQueueName, ExchangeName, "PaymentEmail");
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (ch, ea) =>
            {
                var content = Encoding.UTF8.GetString(ea.Body.ToArray());
                UpdatePaymentResultMessage updatePaymentResultMessage = JsonConvert.DeserializeObject<UpdatePaymentResultMessage>(content);
                HandleMessage(updatePaymentResultMessage).GetAwaiter().GetResult();

                _channel.BasicAck(ea.DeliveryTag, false);
            };
            //_channel.BasicConsume(queueName, false, consumer);
            _channel.BasicConsume(PaymentEmailUpdateQueueName, false, consumer);

            return Task.CompletedTask;
        }

        private async Task HandleMessage(UpdatePaymentResultMessage updatePaymentResultMessage)
        {
            try
            {
                await emailRepo.SendAndLogEmail(updatePaymentResultMessage);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
