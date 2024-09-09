using Microsoft.AspNetCore.Mvc;
using StringManipulator.Interfaces;

namespace StringManipulator.Controllers
{
    public class StringManipulatorMvcController : Controller
    {
        private  IStringManipulator _stringManipulator;

        public StringManipulatorMvcController(IStringManipulator stringManipulator)
        {
            _stringManipulator =  stringManipulator;
        }


        [HttpGet("longest-word")]
        public IActionResult GetLongestWord([FromQuery] string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return View("Error", "Input string cannot be empty.");
            }

            string result = _stringManipulator.LongestWordManipulator(input);
            return View("Result", result);
        }

    }
}
