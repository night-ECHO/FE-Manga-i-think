using Microsoft.AspNetCore.Mvc;

namespace WebMangaMVC.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View("login");
        }

        public ActionResult Signup()
        {
            return View();
        }
    }
}
