using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.FigurasGeometricas
{
    public class Cuadrado : Figura
    {
        public double Lado { get; set; }

        public Cuadrado()
        {
        }

        public Cuadrado(double _lado)
        {
            this.Lado = _lado;
        }


        public override double CalcularArea()
        {
            return (this.Lado * this.Lado);
        }

        public override double CalcularPerimetro()
        {
            return (this.Lado * 4);
        }

    }
}
