using System.ComponentModel.DataAnnotations;
using AlphabetManipulator.Services.GeometricAlphabetService;
using Microsoft.AspNetCore.Mvc;

namespace AlphabetManipulator.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GeometricAlphabetController : ControllerBase
{
    private readonly ILogger<GeometricAlphabetController> _logger;
    private readonly IGeometricAlphabetService _geometricAlphabet;

    public GeometricAlphabetController(ILogger<GeometricAlphabetController> logger, IGeometricAlphabetService geometricAlphabet)
    {
        _logger = logger;
        _geometricAlphabet = geometricAlphabet;
    }

    [HttpGet("{letter}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<string> Get(char letter)
    {
        if (!char.IsLetter(letter))
        {
            _logger.LogWarning($"Get action argument '{nameof(letter)}' must be a letter. Instead received <{letter}>.");
            return BadRequest($"Must provide [A-Z] letter in the URL path, instead provided <{letter}>.");
        }

        var geometricAlphabet = _geometricAlphabet.CreateFromLetter(letter);

        return Ok(geometricAlphabet);
        
    }
}