using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KierbyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Kierby Pepito";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Bio = "I'm an IT student passionate about web development, with skills in HTML, CSS, JavaScript, and ASP.NET Core MVC.";
            return View();
        }

        public IActionResult Skills()
        {
            var skills = new List<string> { "HTML", "CSS", "JavaScript", "C#", "ASP.NET Core MVC" };
            return View(skills);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}