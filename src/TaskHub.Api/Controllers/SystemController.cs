using Microsoft.AspNetCore.Mvc;

namespace TaskHub.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SystemController : ControllerBase
{
    [HttpGet("ping")]
    public IActionResult Ping()
    {
        return Ok("TaskHub API is running");
    }
}
