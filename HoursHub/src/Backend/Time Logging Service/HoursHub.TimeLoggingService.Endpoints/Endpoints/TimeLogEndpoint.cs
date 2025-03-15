using Microsoft.AspNetCore.Mvc;

namespace HoursHub.TimeLoggingService.Endpoints.Endpoints;

[ApiController]
[Route("api/[controller]")]
public class TimeLogEndpoint : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}