using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DemoController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Ok");
    }

    [HttpPost]
    public IActionResult Post([FromBody] InsertDemoObjectDto dto)
    {
        return Ok();
    }
}