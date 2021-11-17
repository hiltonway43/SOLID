using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioAbiertoCerrado
{
    class Tienda
    {
        private List<Inventario> productos;
            public Tienda(List<Inventario> _producto)
        {
            productos = _producto;


        }
        public void CalcularInventario()
        {
            double total = 0;
            foreach (var producto in productos)
            {

                producto.CalcularProducto();
                 Console.WriteLine(producto);
                 total += producto.Prod.Precio;

                //if (producto.Categoria==(int)Categoria.Alimento)
                //{

                //    Console.ForegroundColor = ConsoleColor.Green;
                //    producto.Precio *= 0.8;
                //    Console.WriteLine(producto);
                //       total += producto.Precio;

                //}
                //if (producto.Categoria == (int)Categoria.Medicina)
                //{
                //    Console.ForegroundColor = ConsoleColor.Yellow;
                //    producto.Precio *= 1.2;
                //    Console.WriteLine(producto);
                //    total += producto.Precio;

                //}


            }
            Console.WriteLine($"El total en inventario es {total}");
        }
    
    }
    public enum Categoria
    {
        Medicina = 1,
        Alimento = 2
    }
}

  
