using System;

namespace MediatR.Playground.Commands.Order
{
    public class OrderCreateCommand : IOrderCommand<Guid>
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }
    }
}
