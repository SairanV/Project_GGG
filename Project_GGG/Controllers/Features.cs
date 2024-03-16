using Microsoft.AspNetCore.Mvc;

namespace Project_GGG.Controllers
{
    public class Features : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
