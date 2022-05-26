using Data.DAL;
using Core.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Med.Queries
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private AppDbContext _context;

        public GetProductByIdHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id && !x.IsDeleted);

            return product;
        }
    }
}
