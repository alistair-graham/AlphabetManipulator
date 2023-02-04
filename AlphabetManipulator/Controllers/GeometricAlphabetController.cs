using AlphabetManipulator.Services.GeometricAlphabetService;
using Microsoft.AspNetCore.Mvc;

namespace AlphabetManipulator.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GeometricAlphabetController : ControllerBase
{
    private readonly ILogger<GeometricAlphabetController> _logger;
    private readonly IGeometricAlphabet _geometricAlphabet;

    public GeometricAlphabetController(ILogger<GeometricAlphabetController> logger, IGeometricAlphabet geometricAlphabet)
    {
        _logger = logger;
        _geometricAlphabet = geometricAlphabet;
    }

    [HttpGet("{letter}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<string> Get(char letter)
    {
        var geometricAlphabet = _geometricAlphabet.CreateFromChar(letter);

        return Ok(geometricAlphabet);
    }
}

