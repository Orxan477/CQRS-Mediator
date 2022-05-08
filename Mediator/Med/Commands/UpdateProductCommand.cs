using Mediator.Entities;
using MediatR;

namespace Mediator.Med.Commands
{
    public class UpdateProductCommand:IRequest<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}
