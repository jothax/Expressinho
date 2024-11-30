using Expressinho.Domain.Commands;
using Expressinho.Domain.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expressinho.Api.Controllers
{
    [ApiController]
    [Route("v1/travel")]
    [Authorize]
    public class TravelController : ControllerBase
    {
        [Route("")]
        [HttpPost]
         public GenericCommandResult Create(
            [FromBody]CreateTravelCommand command,
            [FromServices]TravelHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}