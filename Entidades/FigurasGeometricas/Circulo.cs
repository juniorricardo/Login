using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.FigurasGeometricas
{
    public sealed class Circulo: Figura
    {
        public double Radio { get; set; }

        public Circulo(double _radio)
        {
            this.Radio = _radio;
        }

        public override double CalcularArea()
        {
            // Cuadrado utilizando clase Math: Math.Pow(this.Radio,2)
             return (Math.PI * this.Radio * this.Radio);
        }

        public override double CalcularPerimetro()
        {
            return (2*Math.PI*this.Radio);
        }
    }
}
