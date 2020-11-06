using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Playground.Pipelines.Order
{
    public class LoggerPipelineBehavior<TOrderCommand, TResponse> : IPipelineBehavior<TOrderCommand, TResponse>
    {
        private readonly ILogger<LoggerPipelineBehavior<TOrderCommand, TResponse>> _logger;

        public LoggerPipelineBehavior(ILogger<LoggerPipelineBehavior<TOrderCommand, TResponse>> logger)
        {
            _logger = logger;
        }

        public Task<TResponse> Handle(TOrderCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            _logger.LogInformation($"Receive {typeof(TOrderCommand).Name}");
            return next();
        }
    }
}
