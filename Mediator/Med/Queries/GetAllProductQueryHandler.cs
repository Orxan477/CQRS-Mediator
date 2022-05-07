using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Med.Queries
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductVM>>
    {
        public Task<List<GetProductVM>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var model = new GetProductVM()
            {
                Id = 2,
                Name = "Book"
            };
            var model2 = new GetProductVM()
            {
                Id = 3,
                Name = "Monitor"
            };
            return Task.FromResult(new List<GetProductVM> { model,model2});
        }
    }
}
