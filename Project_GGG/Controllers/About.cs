using Microsoft.AspNetCore.Mvc;

namespace Project_GGG.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
