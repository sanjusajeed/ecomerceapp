using Microsoft.AspNetCore.Mvc;

[Route("api/products")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult GetTest()
    {
        return Ok("✅ Product Service is running!");
    }
}
