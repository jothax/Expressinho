using Expressinho.Domain.Commands;
using Expressinho.Domain.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expressinho.Api.Controllers
{
    [ApiController]
    [Route("v1/motorist")]
    [Authorize]
    public class MotoristController : ControllerBase
    {
        [Route("")]
        [HttpPost]
         public GenericCommandResult Create(
            [FromBody]CreateMotoristCommand command,
            [FromServices]MotoristHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}