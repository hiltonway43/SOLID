using PrincipioResponsabilidadUnica;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Empleados emp = new Empleados("Hilder", "Programador", 23, 1000000);
            Console.WriteLine(emp);
           // Console.WriteLine(Impuestos.CalcularImpuestos(emp));
            Impuestos.PagarImpuesto(emp);
        
            

        }
    }
}
