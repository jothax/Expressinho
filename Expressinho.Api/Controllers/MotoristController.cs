using Expressinho.Domain.Entities;
using Expressinho.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expressinho.Api.Controllers
{
    [ApiController]
    [Route("v1/motorist")]
    [Authorize]
    public class MotoristController : ControllerBase
    {
        /* public IEnumerable<Motorist> GetMotorists([FromServices]IMotoristRepository repository)
        {
            
        } */
    }
}