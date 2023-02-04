using Microsoft.AspNetCore.Mvc;

namespace DiamondKata.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DiamondKataController : ControllerBase
{
    private readonly ILogger<DiamondKataController> _logger;

    public DiamondKataController(ILogger<DiamondKataController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{letter}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<string> Get(char letter)
    {
        if (letter == 'a')
        {
            return BadRequest();
        }

        return Ok("a");
    }
}

