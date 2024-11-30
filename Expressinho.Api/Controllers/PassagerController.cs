using Expressinho.Domain.Commands;
using Expressinho.Domain.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expressinho.Api.Controllers
{
    [ApiController]
    [Route("v1/passager")]
    [Authorize]
    public class passagerController : ControllerBase
    {
        [Route("")]
        [HttpPost]
         public GenericCommandResult Create(
            [FromBody]CreatePassagerCommand command,
            [FromServices]PassagerHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}