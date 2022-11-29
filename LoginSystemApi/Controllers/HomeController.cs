using Microsoft.AspNetCore.Mvc;

namespace LoginSystemApi.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet("/")]
    public IActionResult Get() => Ok();
}