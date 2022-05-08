using Mediator.DAL;
using Mediator.Med.Commands;
using Mediator.Med.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IMediator _mediator;
        private AppDbContext _context;

        public ProductController(IMediator mediator, AppDbContext context)
        {
            _mediator = mediator;
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery();
            return Ok(await _mediator.Send(query));
        }
        [HttpPost()]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProductCommand command)
        {
            var query = new UpdateProductCommand() 
            { 
                Id = id,
                Name = command.Name,
                Quantity = command.Quantity,
                Value = command.Value
            };
            return Ok(await _mediator.Send(query));
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = new DeleteProductCommand()
            {
                Id = id,
            };
            return Ok(await _mediator.Send(query));
        }
    }
}
