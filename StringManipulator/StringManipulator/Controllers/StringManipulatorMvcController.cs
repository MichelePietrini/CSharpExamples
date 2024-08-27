using Microsoft.AspNetCore.Mvc;
using StringManipulator.Models;

namespace StringManipulator.Controllers
{
    public class StringManipulatorMvcController : Controller
    {
        private readonly StringManipulator.Models.StringManipulator _stringManipulator;

        public StringManipulatorMvcController()
        {
            _stringManipulator = new LongestWordManipulator();
        }


        [HttpGet("longest-word")]
        public IActionResult GetLongestWord([FromQuery] string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return View("Error", "Input string cannot be empty.");
            }

            string result = _stringManipulator.Manipulate(input);
            return View("Result", result);
        }

    }
}
