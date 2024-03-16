using Microsoft.AspNetCore.Mvc;

namespace Project_GGG.Controllers
{
    public class Blog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
