using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Soccer.Mq.Helpers;
using Soccer.Mq.Models;

namespace Soccer.Mq;
public class MessageQueueHelper
{
    private readonly IModel _model;
    private readonly RabbitMqConfiguration _rabbitMqConfiguration;
    public MessageQueueHelper(IOptions<RabbitMqConfiguration> rabbitMqConnection)
    {
        _rabbitMqConfiguration = rabbitMqConnection.Value;
        ConnectionFactory factory = new ConnectionFactory
        {
            HostName = _rabbitMqConfiguration.HostName,
            UserName = _rabbitMqConfiguration.Username,
            Password = _rabbitMqConfiguration.Password
        };
        _model = factory.CreateConnection().CreateModel();

    }

    public void CreateQueue(string queueName = null!, bool isDurable = false)
    {
        if (queueName == null) queueName = _model.QueueDeclare().QueueName;
        _model.QueueDeclare(queueName, isDurable, false, false, null);
    }
    public void CreateExchange(string exchangeName, string exchangeType, bool isDurable)
    {
        _model.ExchangeDeclare(exchangeName, exchangeType, isDurable, false, null);
    }
    public void BindQueueToExchange(string exchangeName, string queueName = null!)
    {
        if (queueName == null) queueName = _model.QueueDeclare().QueueName;
        _model.QueueBind(queueName, exchangeName, queueName);
    }
    public void PublishMessage(string exchangeName, string queueName, object message)
    {
        byte[] encodedMessage = message.Serialize();
        _model.BasicPublish(exchangeName, queueName, null, encodedMessage);
    }
    public void Recieve(string queueName, Type type)
    {
        var consumer = new EventingBasicConsumer(_model);

        _model.BasicConsume(queueName, false, consumer);

        consumer.Received += (model, ea) =>
        {
            var body = ea.Body;
            var message = body.ToArray();
            _model.BasicAck(ea.DeliveryTag, false);
            System.Console.WriteLine(" ==> " + message.DeSerialize(type));
        };

    }
}