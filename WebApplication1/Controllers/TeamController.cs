using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpGet("GetTeam/{id}")]
        public IActionResult GetTeam(int id)
        {
            return Ok();
        }
    }
}
