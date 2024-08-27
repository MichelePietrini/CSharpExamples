using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StringManipulator.Models;

namespace StringManipulator.Controllers;


// Controller Web API che gestisce le richieste HTTP per manipolare stringhe.
[ApiController]
[Route("api/[controller]")]
public class StringManipulatorApiController : ControllerBase
{

    // Campo per memorizzare l'istanza del manipolatore di stringhe.
    private readonly StringManipulator.Models.StringManipulator _stringManipulator;

    // Nel costruttore, inizializziamo il manipolatore come un'istanza di LongestWordManipulator.
    public StringManipulatorApiController()
    {
        _stringManipulator = new LongestWordManipulator();
    }


    // Endpoint GET per restituire la parola più lunga in una stringa.
    [HttpGet("longest-word")]
    public IActionResult GetLongestWord([FromQuery] string input)
    {
        // Verifichiamo che l'input non sia vuoto o nullo.
        if (string.IsNullOrWhiteSpace(input))
        {
            return BadRequest("Input string cannot be empty.");
        }

        // Usiamo il manipolatore per trovare la parola più lunga e restituirla come JSON.
        string result = _stringManipulator.Manipulate(input);
        return Ok(new { LongestWord = result });
    }
}
