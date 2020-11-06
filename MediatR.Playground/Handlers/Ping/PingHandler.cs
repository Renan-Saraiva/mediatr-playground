using MediatR.Playground.Commands.Ping;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Playground.Handlers.Ping
{
    public class PingHandler : IRequestHandler<PingCommand, string>
    {
        private readonly ILogger<PingHandler> _logger;

        public PingHandler(ILogger<PingHandler> logger)
        {
            _logger = logger;
        }

        public Task<string> Handle(PingCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Executing OrderCreateHandler");
            return Task.FromResult("Pong");
        }
    }
}
