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
    [ApiController]
    [Route("api/[controller]")]
    public class FacturasController : ControllerBase
    {

        private readonly ILogger<FacturasController> _logger;

        public FacturasController(ILogger<FacturasController> logger)
        {
            _logger = logger;

        }
        [HttpGet]
        public List<Factura> Get()
        {

            FacturaRepository repo = new FacturaRepository();
            return repo.BuscarTodas();
        }

        [HttpGet ("{numero:int}")]
        public Factura GetUno(int numero)
        {

            FacturaRepository repo = new FacturaRepository();
            return repo.BuscarUno(numero);
        }

        [HttpPost]
        public void Insertar(Factura factura)
        {

            FacturaRepository repo = new FacturaRepository();
            repo.Insertar(factura);
        }

        [HttpDelete ("{numero:int}")]
        public void Borrar(int Numero)
        {
            FacturaRepository repo = new FacturaRepository();
            repo.Borrar(new Factura(Numero));
        }

    }
}
