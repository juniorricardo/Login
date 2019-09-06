using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Propiedades
        
        //Datos que pueden ser visibles desde fuera de la clase 
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        #endregion

        #region Atributos

        //Datos que son visibles solo internamente en la clase Persona
        private double identificadorInterno;
        
        #endregion

        #region Constructores
       
        // Constructor por defecto
        public Persona()
        {

        }

        // Constructor de clase
        public Persona(int _dni, string _nombre, string _apellido)
        {
            this.Dni = _dni;
            this.Apellido = _apellido;
            this.Nombre = _nombre;
       
        }

        public Persona(int _dni, string _nombre)
        {
            this.Dni = _dni;
            this.Nombre = _nombre;
        }

        #endregion

        #region Metodos      

        public void Saludar()
        {
            Console.WriteLine("Hola soy " + Nombre);
        }

        public void Saludar(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.WriteLine("Hola soy " + Nombre + " " + color);
            Console.BackgroundColor = ConsoleColor.Black; // Vuelvo a dejar el color de la consola original
        }

        public void SaludarNombreApellido()
        {
            Console.WriteLine("Hola soy " + Nombre + " " + Apellido);
        }


        #endregion

        #region MetodosSobreescritos

        public override string ToString()
        {
            string NombreApellido = String.Format("Nombre: {0}, Apellido = {1}",this.Nombre,this.Apellido); 

            return NombreApellido;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }


        #endregion
    }
}
