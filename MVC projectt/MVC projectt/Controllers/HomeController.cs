using Microsoft.AspNetCore.Mvc;
using MVC_projectt.Helpers;
//using MVC_projectt.Models;
using System.Diagnostics;

namespace MVC_projectt.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM IschiTable");
            return View(dt);
        }

        public async Task<IActionResult> Table()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM IschiTable");
            return View(dt);
        }
    }
}