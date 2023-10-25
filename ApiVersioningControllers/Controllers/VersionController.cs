using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningControllers.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VersionController : ControllerBase
{
    [HttpGet(nameof(Version1))]
    [ApiVersion(1)] 
    public IActionResult Version1()
    {
        return Ok();
    }

    [HttpGet(nameof(Version2))]
    [ApiVersion(2)]
    public IActionResult Version2()
    {
        return Ok();
    }
}
