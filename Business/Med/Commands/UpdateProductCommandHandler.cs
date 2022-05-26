using Core.Entities;
using Data.DAL;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Med.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Product>
    {
        private AppDbContext _context;

        public UpdateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id && !x.IsDeleted);
            if (request.Name != null)
            {
                product.Name = request.Name;
            }
            if (request.Quantity != 0)
            {
                product.Quantity = request.Quantity;
            }
            if (request.Value != 0)
            {
                product.Amount = request.Value;
            }
            //if (request.IsDeleted == true)
            //{
            //    product.IsDeleted = request.IsDeleted;
            //}
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
