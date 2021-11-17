using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioResponsabilidadUnica
{
    class Impuestos
    {
    
        const double porcentaje=0.30;

        public static double CalcularImpuestos(Empleados emp) => emp.Sueldo * porcentaje;

        public static void PagarImpuesto(Empleados emp)
        {
            double imp = CalcularImpuestos(emp);
            Console.WriteLine($"Se le paga de impuesto: ${imp}");

        }
    }
}
