using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_GGG.Models;
using System.Diagnostics;
using System.Security.Claims;
using System.Globalization;
using Microsoft.Extensions.Options;

namespace Project_GGG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProjectGGGContext _db;
        private IConfiguration _config;
        private IOptions<ApiEndpoint> _settings;

        public HomeController(ILogger<HomeController> logger, 
            IConfiguration config,
             IOptions<ApiEndpoint> settings,
            ProjectGGGContext db)
        {
            _logger = logger;
            _config = config;
            _settings = settings;
            _db = db;
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }


        [TypeFilter(typeof(CustomExceptionFilter), Order = 2)]
        [TimeElapsed]
        public IActionResult Index(string culture = "")
        {
            GetCultures(culture);

            var data0 = _settings.Value.Url;
            var data =
                _config.GetSection("Middleware")
                .GetSection("EnableContentMiddleware")
                .Value;

            var data2 =
            _config.GetSection("Middleware")
            .GetValue<bool>("EnableContentMiddleware");


            var data3 = _config
                .GetSection("Middleware:EnableContentMiddleware")
                .Value;

            return View();
        }

        public string GetCultures(string code)
        {
            if (!string.IsNullOrWhiteSpace(code))
            {
                CultureInfo.CurrentCulture = new CultureInfo(code);

                CultureInfo.CurrentUICulture = new CultureInfo(code);
            }
            return "";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
