using Mediator.Entities;
using MediatR;

namespace Mediator.Med.Commands
{
    public class DeleteProductCommand:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
