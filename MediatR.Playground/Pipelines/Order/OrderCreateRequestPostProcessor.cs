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
    public class OrderCreateRequestPostProcessor : IRequestPostProcessor<OrderCreateCommand, Guid>
    {
        private readonly ILogger<OrderCreateRequestPostProcessor> _logger;

        public OrderCreateRequestPostProcessor(ILogger<OrderCreateRequestPostProcessor> logger)
        {
            _logger = logger;
        }

        public Task Process(OrderCreateCommand request, Guid response, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Post request order create");
            return Task.CompletedTask;
        }
    }

    public class OrderCreateRequestPostProcessor2 : IRequestPostProcessor<OrderCreateCommand, Guid>
    {
        private readonly ILogger<OrderCreateRequestPostProcessor2> _logger;

        public OrderCreateRequestPostProcessor2(ILogger<OrderCreateRequestPostProcessor2> logger)
        {
            _logger = logger;
        }

        public Task Process(OrderCreateCommand request, Guid response, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Post request order create 2");
            return Task.CompletedTask;
        }
    }
}
