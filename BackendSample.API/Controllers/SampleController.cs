using System;
using System.ComponentModel;
using System.Threading.Tasks;
using BackendSample.API.Commands;
using BackendSample.API.DTO;
using BackendSample.API.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendSample.API.Controllers
{
    [ApiController]
    [Route("api/sample")]
    [Produces("application/json")]
    [DisplayName("SampleAPI")]
    public class SampleController : ControllerBase
    {
        IMediator _mediator;

        public SampleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> SampleGet([FromRoute] Guid Id)
        {     
            SampleQuery query = new SampleQuery()
            {
                Id = Id
            };

            var result = await _mediator.Send(query);

            var response = new SampleGetResponse()
            {
                Id = result.Id,
                SampleParam = result.SampleParam
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> SamplePost([FromRoute] Guid Id, [FromBody] SapmlePostRequest request)
        {
            SampleCommand command = new SampleCommand()
            {
                Id = Id,
                SampleParam = request.SampleParam
            };

            var result = await _mediator.Send(command);

            return result ? Ok() : BadRequest();
        }
    }
}
