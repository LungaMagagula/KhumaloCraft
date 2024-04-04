using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
            public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult MyWork()
        {
            return View();
        }

    }
}
