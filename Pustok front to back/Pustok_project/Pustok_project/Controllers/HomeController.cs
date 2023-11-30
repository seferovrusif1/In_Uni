using Microsoft.AspNetCore.Mvc;
using Pustok_project.Models;
using System.Diagnostics;

namespace Pustok_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}