using MediatR.Pipeline;
using MediatR.Playground.Commands.Order;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Playground.Pipelines.Order
{
    public class OrderCreateRequestPreProcessor : IRequestPreProcessor<OrderCreateCommand>
    {
        private readonly ILogger<OrderCreateCommand> _logger;

        public OrderCreateRequestPreProcessor(ILogger<OrderCreateCommand> logger)
        {
            _logger = logger;
        }

        public Task Process(OrderCreateCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Pre request order create");
            return Task.CompletedTask;
        }
    }
}
