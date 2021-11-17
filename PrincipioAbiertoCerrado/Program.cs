using System;
using System.Collections.Generic;

namespace PrincipioAbiertoCerrado
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Inventario> MisProductos = new List<Inventario>
            {
                new InventarioAlimento(new Producto("Papa",1,200.0)),
                new InventarioAlimento(new Producto("Yuca",1,600.0)),
                new InventarioMedicamento(new Producto("Alkaserse",2,400.0)),
                new InventarioMedicamento(new Producto("Aspirina",2,200.0))
            };

            Tienda tienda = new Tienda(MisProductos);
            tienda.CalcularInventario();
        }
    }
}
