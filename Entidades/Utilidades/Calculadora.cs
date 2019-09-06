using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Utilidades
{
    public static class Calculadora
    {
        public static string marca;

        public static int Sumar(int numA, int numB)
        {
            return (numA + numB);
        }

        public static int Restar(int numA, int numB)
        {
            return (numA - numB);
        }

        public static int Multiplicar(int numA, int numB)
        {
            return (numA * numB);
        }

        public static int Dividir(int numA, int numB)
        {
            return (numA / numB);
        }
    }
}
