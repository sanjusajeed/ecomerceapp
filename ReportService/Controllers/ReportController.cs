using Microsoft.AspNetCore.Mvc;

[Route("api/reports")]
[ApiController]
public class ReportController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult GetTest()
    {
        return Ok("✅ Report Service is running!");
    }
}
