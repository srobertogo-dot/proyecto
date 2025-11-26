using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDataBlindingP2C1
{
    public class Producto 
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto()
        {
            Nombre = "no definido";
            Precio = 0;

        }
        public Producto(string nom, double pre)
        {
            Nombre = nom;
            Precio = pre;
        }
        public string verDatos()
        {
            return (Nombre + " " + Precio.ToString());
        }
    }
}
