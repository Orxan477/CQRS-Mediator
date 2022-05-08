using Mediator.Entities;
using MediatR;

namespace Mediator.Med.Queries
{
    public class GetProductByIdQuery:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
