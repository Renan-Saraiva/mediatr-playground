using MediatR.Playground.Commands.Order;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Playground.Pipelines.Order
{
    public class OrderCreatePipelineBehavior : IPipelineBehavior<OrderCreateCommand, Guid>
    {
        private readonly ILogger<OrderCreatePipelineBehavior> _logger;

        public OrderCreatePipelineBehavior(ILogger<OrderCreatePipelineBehavior> logger)
        {
            _logger = logger;
        }

        public Task<Guid> Handle(OrderCreateCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<Guid> next)
        {
            _logger.LogInformation($"Process pipeline behavior order create command");
            return next();
        }
    }

    public class OrderCreatePipelineBehavior2 : IPipelineBehavior<OrderCreateCommand, Guid>
    {
        private readonly ILogger<OrderCreatePipelineBehavior2> _logger;

        public OrderCreatePipelineBehavior2(ILogger<OrderCreatePipelineBehavior2> logger)
        {
            _logger = logger;
        }

        public Task<Guid> Handle(OrderCreateCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<Guid> next)
        {
            _logger.LogInformation($"Process pipeline behavior order create command 2");
            return next();
        }
    }
}
