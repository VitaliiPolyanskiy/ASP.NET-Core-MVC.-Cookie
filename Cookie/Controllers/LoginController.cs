using Microsoft.AspNetCore.Mvc;
using Cookie.Models;

namespace Cookie.Controllers;

public class LoginController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Login login)
    {
        if (ModelState.IsValid)
        {
            var options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(10) // термін зберігання кукі - 10 днів
            };

            Response.Cookies.Append("login", login.UserName!, options); // створення кукі
            return RedirectToAction("Index", "Home");
        }
        return View(login);
    }
}