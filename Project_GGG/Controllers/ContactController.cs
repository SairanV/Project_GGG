using Microsoft.AspNetCore.Mvc;

namespace Project_GGG.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
