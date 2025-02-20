#region
//using MassTransit;
//using Producer;
//using Shared.Messages;

//string queueName = "example-queue";

//// Bus yapılandırması
//IBusControl bus = Bus.Factory.CreateUsingRabbitMq(cfg =>
//{
//    cfg.Host("localhost", "/", h =>
//    {
//        h.Username("guest");
//        h.Password("guest");
//    });
//});

//await bus.StartAsync();

//ISendEndpoint sendEndpoint = await bus.GetSendEndpoint(new Uri($"queue:{queueName}"));

//Console.Write("Gönderilecek mesajı girin: ");
//string message = Console.ReadLine();

//await sendEndpoint.Send<IMessage>(new ExampleMessage
//{
//    Text = message
//});

//Console.WriteLine("Mesaj gönderildi.");

//Console.ReadLine();
//await bus.StopAsync();
#endregion

#region
using MassTransit;
using Microsoft.Extensions.Hosting;
using static MassTransit.MessageHeaders;

await Host.CreateDefaultBuilder(args)
#endregion

