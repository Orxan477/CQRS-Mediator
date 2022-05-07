using MediatR;

namespace Mediator.Med.Commands
{
    public class CreateProductCommand:IRequest<int>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}
