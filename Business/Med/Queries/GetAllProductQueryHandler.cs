using Data.DAL;
using Core.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Med.Queries
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<Product>>
    {
        private AppDbContext _context;

        public GetAllProductQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            List<Product> products =await _context.Products.Where(x=>!x.IsDeleted).ToListAsync() ;

            return products;
        }
    }
}
