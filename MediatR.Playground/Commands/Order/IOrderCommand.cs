using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.Playground.Commands.Order
{
    public interface IOrderCommand<TResponse> : IRequest<TResponse> { }
}
