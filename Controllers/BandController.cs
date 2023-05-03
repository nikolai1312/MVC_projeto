using Microsoft.AspNetCore.Mvc;

namespace MVC_projeto.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateBand()
        {
            return View();
        }

        public IActionResult EditBand()
        {
            return View();
        }

        public IActionResult DeleteBand() {
            return View();
        }
    }
}
