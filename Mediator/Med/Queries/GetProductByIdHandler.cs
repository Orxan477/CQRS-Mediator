using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Med.Queries
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, GetProductVM>
    {
        public async Task<GetProductVM> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductVM()
            {
                Id = 5,
                Name = "Tekrarsiz"
            };
            return viewModel;
            //Get product from repository
        }
    }
}
