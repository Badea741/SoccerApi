namespace Soccer.Mq.Models;
[Serializable]
public class RabbitMqConfiguration
{
    public string HostName { get; set; } = "localhost";
    public string Username { get; set; } = "guest";
    public string Password { get; set; } = "guest";
}