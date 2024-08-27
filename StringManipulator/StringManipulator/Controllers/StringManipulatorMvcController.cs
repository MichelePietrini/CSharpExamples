using Microsoft.AspNetCore.Mvc;
using StringManipulator.Models;

namespace StringManipulator.Controllers
{
    public class StringManipulatorMvcController : Controller
    {
        // Campo per memorizzare l'istanza del manipolatore di stringhe.
        private readonly StringManipulator.Models.StringManipulator _stringManipulator;

        // Nel costruttore, inizializziamo il manipolatore come un'istanza di LongestWordManipulator.
        public StringManipulatorMvcController()
        {
            _stringManipulator = new LongestWordManipulator();
        }
        // Action GET per restituire la parola più lunga in una stringa come HTML.
        [HttpGet("longest-word")]
        public IActionResult GetLongestWord([FromQuery] string input)
        {
            // Verifichiamo che l'input non sia vuoto o nullo.
            if (string.IsNullOrWhiteSpace(input))
            {
                return View("Error", "Input string cannot be empty.");
            }

            // Usiamo il manipolatore per trovare la parola più lunga e restituirla come risultato HTML.
            string result = _stringManipulator.Manipulate(input);
            return View("Result", result);
        }
    }
}
