using MediatR;
using Microsoft.AspNetCore.Mvc;
using MillionRealEstateTechTest.Application.Commands.CreateProperty;
using MillionRealEstateTechTest.Application.Entities;  // <--- Esto es importante
using MillionRealEstateTechTest.Application.Queries.GetAllProperties;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MillionRealEstateTechTest.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PropertiesController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreatePropertyCommand command)
        {
            var propertyId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAll), new { id = propertyId }, propertyId);
        }

        [HttpGet]
        public async Task<ActionResult<List<Property>>> GetAll()
        {
            var properties = await _mediator.Send(new GetAllPropertiesQuery());
            return Ok(properties);
        }
    }
}
