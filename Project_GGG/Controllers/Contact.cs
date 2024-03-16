using Microsoft.AspNetCore.Mvc;

namespace Project_GGG.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
