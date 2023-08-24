using Microsoft.AspNetCore.Mvc;

namespace Users.Api.Controllers;

public class TestController : ControllerBase
{
    public TestController()
    {
    }

    [HttpGet("test")]
    public ActionResult GetTestMessage()
    {
        return Ok("You got test message!");
    }
}