using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;
using WebMangaMVC.Models;

namespace WebMangaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("index");
        }

        // Add missing actions for your pages
        public IActionResult Categories()
        {
            return View("categories");
        }

        public IActionResult AnimeDetails()
        {
            return View("anime-detail");
        }

        public IActionResult AnimeWatching()
        {
            return View("anime-watching");
        }

        public IActionResult BlogDetails()
        {
            return View("blog-details");
        }
        public ActionResult Blog()
        {
            return View("blog");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
