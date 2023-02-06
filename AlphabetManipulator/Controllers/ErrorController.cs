using Microsoft.AspNetCore.Mvc;

namespace AlphabetManipulator.Controllers;

[ApiController]
public class ErrorController : ControllerBase
{
    [Route("/error")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public IActionResult HandleError() =>
        Problem();
}

