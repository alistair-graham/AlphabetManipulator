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
    public ActionResult<string> Get(char letter)
    {
        if (!char.IsLetter(letter))
        {
            return BadRequest($"Must provide [A-Z] letter in the URL path, instead provided <{letter}>.");
        }

        var geometricAlphabet = _geometricAlphabet.CreateFromLetter(letter);

        return Ok(geometricAlphabet);
        
    }
}