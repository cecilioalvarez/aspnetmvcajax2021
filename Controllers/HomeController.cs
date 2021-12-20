using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcajax.Models;

namespace mvcajax.Controllers
{
    public class HomeController : Controller
    {
        static List<string> textos = new List<string>();
        static HomeController()
        {

            textos.Add("hola");
            textos.Add("que");
            textos.Add("tal");
            textos.Add("estas");

        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
            ViewBag.textos = textos;
            return View();
        }

        public ActionResult Datos()
        {
            return Content("tu");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
