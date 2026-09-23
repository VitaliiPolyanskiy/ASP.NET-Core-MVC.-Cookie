using Microsoft.AspNetCore.Mvc;

namespace Cookie.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        if (!Request.Cookies.ContainsKey("login"))
        {
            return RedirectToAction("Create", "Login");
        }
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Logout()
    {
        Response.Cookies.Delete("login"); // видалення кукі
        return RedirectToAction("Create", "Login");
    }
}