using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_GGG.Models;

namespace Project_GGG.Controllers
{
    public class PricingController : Controller
    {
        private IWebHostEnvironment host;


        public PricingController(IWebHostEnvironment host)
        {
            this.host = host;
        }



        public async Task<IActionResult> Index(int page)
        {
            List<Pricing> listRooms = new List<Pricing>();
            using (var httpClient = new HttpClient())
            {
                using (var responce = await httpClient
                    .GetAsync("http://localhost:5161/api/Pricing"))
                {
                    var content = await responce
                        .Content.ReadAsStringAsync();

                    listRooms = JsonConvert
                        .DeserializeObject<List<Pricing>>(content);
                }
            }

            //ViewBag.Clients = _db.Сlients.ToList();

            return View();
        }

        //string email, string name
        //User user
        //var data = Request.Form;
        [HttpPost]
        public IActionResult Subcribes(IFormFile userFile)
        //Microsoft.AspNetCore.Http;
        {
            string path = Path.Combine(host.WebRootPath,
                "Files",
                userFile.FileName);


            using (var streame = new FileStream(path, FileMode.Create))
            {
                userFile.CopyTo(streame);
            }

            //return View("Index");
            //return View("~/Views/Home/Privacy.cshtml");
            return RedirectToAction("Index");
        }


        public string GetSomeText()
        {
            return "Text";
        }


    }
}
