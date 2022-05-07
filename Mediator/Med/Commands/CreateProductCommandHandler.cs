using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Med.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        public Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(5);
            //Repositoryden gelmelidir
        }
    }
}
