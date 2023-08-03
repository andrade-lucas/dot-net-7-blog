using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
    [HttpGet("")]
    public IActionResult Get([FromServices] IConfiguration config)
    {
        return Ok(new {
            status = "Ok",
            env = config.GetValue<string>("env")
        });
    }
}
