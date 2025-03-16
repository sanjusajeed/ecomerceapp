using Microsoft.AspNetCore.Mvc;

[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult GetTest()
    {
        return Ok("✅ User Service is running!");
    }
}
