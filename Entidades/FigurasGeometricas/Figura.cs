using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.FigurasGeometricas
{

    // Clase "base" abstracta de la que heradarán las demas figuras. 
    public abstract class Figura
    {
        // Propiedades
        public string Color { get; set; }
        public string Relleno { get; set; }
        public string Linea { get; set; }

        //Constante
        private const double PI = 3.14;


        //Metodos Abstractos
        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();



    }
}
