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

        public IActionResult ListaFacturas()
        {
            FacturaRepository repo = new FacturaRepository();
            ViewBag.listafacturas = repo.BuscarTodas();
            return View();
        }

        public IActionResult FormularioInsertar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertarJSON( [FromBody] Factura factura)
        {
            Console.WriteLine(factura.Numero);
            Console.WriteLine(factura.Concepto);
            Console.WriteLine(factura.Importe);
            FacturaRepository repo = new FacturaRepository();
            repo.Insertar(factura);
            return Json("Success");
        }

        public IActionResult Insertar(Factura factura)
        {
            FacturaRepository repo = new FacturaRepository();
            repo.Insertar(factura);
            return RedirectToAction("ListaFacturas","Home");
        }

        public JsonResult ListaFacturasJSON()
        {
            FacturaRepository repo = new FacturaRepository();
            List<Factura> lista = repo.BuscarTodas();

            return Json(lista);
        }
        public JsonResult ListaFacturasJSONFiltro(string concepto)
        {
            FacturaRepository repo = new FacturaRepository();


            List<Factura> lista;
            if (concepto != null)
            {
                lista = repo.BuscarTodasPorConcepto(concepto);
            }
            else
            {
                lista = repo.BuscarTodas();
            }



            return Json(lista);
        }


        public ActionResult Datos()
        {
            return Content("tu del servidor");
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
