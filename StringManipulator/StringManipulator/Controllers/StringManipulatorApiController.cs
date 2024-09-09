using Microsoft.AspNetCore.Mvc;
using StringManipulator.Interfaces;


namespace StringManipulator.Controllers;


/// <summary>
/// Questa classe rappresenta un controller API per la manipolazione di stringhe.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class StringManipulatorApiController : ControllerBase
{
    private readonly IStringManipulator _stringManipulator;

    /// <summary>
    /// Crea una nuova istanza della classe StringManipulatorApiController.
    /// </summary>
    public StringManipulatorApiController(IStringManipulator stringManipulator)
    {
        _stringManipulator = stringManipulator;
    }

    /// <summary>
    /// Ottiene la parola più lunga all'interno di una stringa.
    /// </summary>
    /// <param name="input">La stringa di input.</param>
    /// <returns>Un oggetto IActionResult che rappresenta il risultato dell'operazione.</returns>
    [HttpGet("longest-word")]
    public IActionResult GetLongestWord([FromQuery] string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return BadRequest("Input string cannot be empty.");
        }

        string result = _stringManipulator.LongestWordManipulator(input);
        return Ok(new { LongestWord = result });
    }
}
