using MediatR;

namespace Mediator.Med.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductVM>
    {
        public int Id { get; set; }

    }
}
