using Core.Entities;
using MediatR;

namespace Business.Med.Queries
{
    public class GetProductByIdQuery:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
