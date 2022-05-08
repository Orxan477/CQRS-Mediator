using Mediator.DAL;
using Mediator.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Med.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Product>
    {
        private AppDbContext _context;

        public DeleteProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id && !x.IsDeleted);
            product.IsDeleted = true;
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
