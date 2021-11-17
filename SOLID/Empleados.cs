using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioResponsabilidadUnica
{
    class Empleados
    {
        public string Nombre{ get; set; }
        private string Puesto { get; set; }
        private int Edad { get; set; }
        public double Sueldo { get; set; }

        public Empleados(string _nombre, string _puesto, int _edad, double _sueldo)
        {
            Nombre = _nombre;
            Puesto = _puesto;
            Edad = _edad;
            Sueldo = _sueldo;
        }

        public override string ToString()
        {
            return string.Format($"{Nombre},{Puesto},{Edad},{Sueldo}");
        }

       
    }
}
