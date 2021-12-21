using System.Collections.Generic;
namespace mvcajax.Models
{

    public class FacturaRepository
    {


        public List<Factura> BuscarTodas()
        {


          Factura f1 = new Factura(1, "ordenador", 200);
            Factura f2 = new Factura(2, "televisor", 200);
            Factura f4 = new Factura(4, "tele", 500);
            Factura f3 = new Factura(3, "tablet", 200);
            Factura f5 = new Factura(5, "televisorSuper", 700);

            List<Factura> lista = new List<Factura>();
            List<Factura> lista2 = new List<Factura>();
            lista.Add(f1);
            lista.Add(f2);
            lista.Add(f3);
            lista.Add(f4);
            lista.Add(f5);

            return lista;

        }

        public List<Factura> BuscarTodasPorConcepto(string concepto)
        {


            Factura f1 = new Factura(1, "ordenador", 200);
            Factura f2 = new Factura(2, "televisor", 200);
            Factura f4 = new Factura(4, "tele", 500);
            Factura f3 = new Factura(3, "tablet", 200);
            Factura f5 = new Factura(5, "televisorSuper", 700);

            List<Factura> lista = new List<Factura>();
            List<Factura> lista2 = new List<Factura>();
            lista.Add(f1);
            lista.Add(f2);
            lista.Add(f3);
            lista.Add(f4);
            lista.Add(f5);

            foreach (Factura f in lista)
            {

                if (f.Concepto.StartsWith(concepto))
                {
                    lista2.Add(f);
                }
            }


            return lista2;

        }

    }
}