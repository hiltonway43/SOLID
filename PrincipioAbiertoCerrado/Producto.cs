using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioAbiertoCerrado
{
    class Producto
    {
       public string Nombre { get; set; }
       public int Categoria { get; set; }
       public double Precio { get; set; }


        public Producto(string _nombre, int _categoria, double _precio)
        {
            Nombre = _nombre;
            Categoria = _categoria;
            Precio = _precio;
        }

        public override string ToString()
        {
            return string.Format($"El producto {Nombre} tiene el precio de {Precio}");
        }

    }
}
