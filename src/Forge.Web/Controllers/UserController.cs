using Microsoft.AspNetCore.Mvc;

namespace Forge.Web.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    [HttpGet("/@me")]
    public IActionResult Get()
    {
        return Ok("User endpoint is working.");
    }

    [HttpPost("/@me")]
    public IActionResult Update()
    {
        return Ok("User update endpoint is working.");
    }
}