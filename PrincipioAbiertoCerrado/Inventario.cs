using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioAbiertoCerrado
{
   abstract class Inventario
    {
       // protected Producto producto;

        public Producto Prod { get; set; }

        public Inventario(Producto _producto )
        {
            Prod = _producto;
        }
        public override string ToString()
        {
            return Prod.ToString();
        }
        public abstract double CalcularProducto();
    }
}
