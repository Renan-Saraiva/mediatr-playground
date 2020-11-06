using MediatR.Playground.Commands.Order;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Playground.Handlers.Order
{
    public class OrderCreateHandler : IRequestHandler<OrderCreateCommand, Guid>
    {
        private readonly ILogger<OrderCreateHandler> _logger;

        public OrderCreateHandler(ILogger<OrderCreateHandler> logger)
        {
            _logger = logger;
        }

        public Task<Guid> Handle(OrderCreateCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Executing order create handler");
            return Task.FromResult(Guid.NewGuid());
        }
    }
}
