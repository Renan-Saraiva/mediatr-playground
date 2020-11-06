using MediatR.Playground.Commands.Ping;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatR.Playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public Task<string> Post()
        {
            return _mediator.Send(new PingCommand());
        }
    }
}
