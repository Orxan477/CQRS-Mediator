﻿using MediatR;
using System.Collections.Generic;

namespace Mediator.Med.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductVM>>
    {

    }
}
