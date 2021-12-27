
namespace mvcajax.Models
{
    public class Factura
    {

        public int Numero { get; set; }
        public string Concepto { get; set; }

        public double Importe { get; set; }

        public Factura(int Numero, string Concepto, double Importe)
        {
            this.Numero=Numero;
            this.Concepto=Concepto;
            this.Importe=Importe;

        }
        public Factura() {
            
        }
        public Factura (int Numero) {
            this.Numero=Numero;
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
           
           Factura otra= (Factura) obj;
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            if (otra.Numero==Numero) {

                return true;
            }else {
                return false;
            }
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
        
            return Numero.GetHashCode();
        }
    }
}
