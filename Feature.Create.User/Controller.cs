using Feature.Create.User;
using MediatR;

namespace Feature.Create.UserAll
{
    [ApiController]
    [Route("api")]
    public class Controller : ControllerBase
    {
        [HttpPost("CreateUser")]
        public IActionResult Post([FromBody] Model user)
        {
            return Ok();
        }

        [HttpGet("Pong")]
        public async Task<IActionResult> Get([FromServices] IMediator mediator)
        {
            return Ok(await mediator.Send(new PingHandler.PingRequest()));
        }
    }
}