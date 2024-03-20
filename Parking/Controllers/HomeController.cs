using Microsoft.AspNetCore.Mvc;

namespace Parking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
