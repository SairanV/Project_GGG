using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Project_GGG.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "admin798@gmail.com" && password == "adminadmin")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, email)
                };

                var claimIdentity = new ClaimsIdentity(claims, "login");

                HttpContext.SignInAsync
                (CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));
            }

            return RedirectToAction("Index", "Home");
        }

        

        [HttpPost]
        public async Task<IActionResult> SignUp(string email, string password)
        {
            // Здесь вы обычно проверяете введенные данные и сохраняете пользователя в базе данных.
            // В демонстрационных целях я просто использую жестко заданные значения для email и пароля
            if (email == "user@example.com" && password == "password123")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, email)
                    // Вы можете добавить сюда дополнительные утверждения по мере необходимости
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home"); // Перенаправление на главную страницу после успешной регистрации
            }

            // Если регистрация не удалась, вы можете вернуться на страницу регистрации с сообщением об ошибке
            ModelState.AddModelError(string.Empty, "Invalid email or password.");
            return View();
        }
    


        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
