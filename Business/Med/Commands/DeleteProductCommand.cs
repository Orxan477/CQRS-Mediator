using Core.Entities;
using MediatR;

namespace Business.Med.Commands
{
    public class DeleteProductCommand:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
