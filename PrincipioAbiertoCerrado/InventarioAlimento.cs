using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioAbiertoCerrado
{
    class InventarioAlimento: Inventario
    {
        public InventarioAlimento(Producto prod): base(prod)
        {

        }

        public override double CalcularProducto()
        {
            Prod.Precio *= 0.8;
            return Prod.Precio;
        }
    }
}
