using Microsoft.AspNetCore.Mvc;
using Pustok_project.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Pustok_project.Contexts;

namespace Pustok_project.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {

            using PustokDbContext content = new PustokDbContext();
            var sliders = await content.Sliders.ToListAsync();
            return View(sliders);
        }

    }
}