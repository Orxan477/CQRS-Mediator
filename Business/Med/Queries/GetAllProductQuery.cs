using Core.Entities;
using MediatR;
using System.Collections.Generic;

namespace Business.Med.Queries
{
    public class GetAllProductQuery:IRequest<List<Product>>
    {

    }
}
