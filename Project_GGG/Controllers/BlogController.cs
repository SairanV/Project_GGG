using Microsoft.AspNetCore.Mvc;

namespace Project_GGG.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
