using Microsoft.AspNetCore.Mvc;

namespace StringManipulator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
