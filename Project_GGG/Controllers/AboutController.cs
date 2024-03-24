using Microsoft.AspNetCore.Mvc;

namespace Project_GGG.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
