using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado: Persona
    {
        public int    Matricula { get; set; }
        public string Sector { get; set; }
        public string Rol { get; set; }
        public double SueldoBruto { get; set; }
        public List<string> Tareas { get; set; }

        private int cargasSociales = 17;

        public double CalcularSueldoNeto()
        {
            return (this.SueldoBruto * (100-this.cargasSociales));
        }

        public double CalcularImpuestoGanancias()
        {
            return 0;
        }
   
    }
}
