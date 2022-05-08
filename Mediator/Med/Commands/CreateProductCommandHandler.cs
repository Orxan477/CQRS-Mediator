using Mediator.DAL;
using Mediator.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Med.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private AppDbContext _context;

        public CreateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product
            {
                Name = request.Name,
                Quantity = request.Quantity,
                Amount = request.Value,
                IsDeleted = false,
            };
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
            //Repositoryden gelmelidir
        }
    }
}
