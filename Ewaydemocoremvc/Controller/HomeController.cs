using Microsoft.AspNetCore.Mvc;

namespace Ewaydemocoremvc.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
