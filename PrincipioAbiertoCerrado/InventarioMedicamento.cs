using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioAbiertoCerrado
{
    class InventarioMedicamento:Inventario
    {
       
        public InventarioMedicamento(Producto prod) : base(prod)
        {

        }

        public override double CalcularProducto()
        {
            Prod.Precio *= 0.12;
            return Prod.Precio;
        }
    }
}
