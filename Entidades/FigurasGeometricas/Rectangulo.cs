using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.FigurasGeometricas
{
    public class Rectangulo : Figura
    {

        private double lado1;

        // Propiedad no autoimplementada que lee/modifica el atributo lado1
        // Solo permite modificar el atributo cuando el valor es mayor a "0"
        public double Lado1
        {
            get
            {
                return lado1;
            }
            set
            {
                if(value > 0)
                {
                    lado1 = value;
                }
            }
        }

       public double Lado2 { get; set; }

        public override double CalcularArea()
        {
            double area = this.Lado1 * this.Lado2;

            return area;
        }

        public override double CalcularPerimetro()
        {
            return ((this.Lado1*2) + (this.Lado2*2));
        }


    }
}
