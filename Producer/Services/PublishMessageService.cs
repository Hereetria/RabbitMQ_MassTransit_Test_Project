using MassTransit;
using Microsoft.Extensions.Hosting;
using Shared.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Services
{
    public class PublishMessageService : BackgroundService
    {
        readonly IPublishEndpoint _publishEndpoint;

        public PublishMessageService(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int i = 0;
            while (true) 
            {
                ExampleMessage message = new()
                {
                    Text = $"Message {++i}"
                };

                _publishEndpoint.Publish(message);
            }
        }
    }
}
