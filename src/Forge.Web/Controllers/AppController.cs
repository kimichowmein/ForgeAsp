using Microsoft.AspNetCore.Mvc;

namespace Forge.Web.Controllers;

[ApiController]
public class AppController : ControllerBase
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return Ok("Forge Web API is running.");
    }
}