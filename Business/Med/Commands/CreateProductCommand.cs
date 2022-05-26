using Core.Entities;
using MediatR;

namespace Business.Med.Commands
{
    public class CreateProductCommand:IRequest<Product>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}
