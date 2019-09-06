using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.FigurasGeometricas;
using Entidades.Utilidades;
using Entidades;
using Negocio;
using System.Data.SqlClient;
using AccesoDatos;
using System.Data;

namespace Presentacion
{
    class Program
    {
        #region Ejemplos

        public static bool LoguearUsuario()
        {

            bool logueado = false;

            for (int i = 0; i < 3 && logueado == false; i++)
            {
                Console.WriteLine("Ingrese su usuario");

                string nombreUsuario = Console.ReadLine();

                Console.WriteLine("Ingrese su password");

                int password = Convert.ToInt32(Console.ReadLine());

                if (nombreUsuario == "Juan" && password == 123)
                {
                    Console.WriteLine("Bienvenido a la aplicacion");
                    logueado = true;
                }
                else
                {
                    Console.WriteLine("Usuario no valido");
                }
            }

            Console.ReadKey();
            return logueado;
        }

        public static void PruebaObjetosPersonas()
        {
            // Instanciando mi primer objecto
            Persona objPersona1 = new Persona(123, "Juan", "Perez");
            Persona objPersona2 = new Persona(456, "Luis", "Gomez");
            Persona objPersona3 = new Persona(789, "Maria");


            Persona objPersona4 = new Persona();

            objPersona4.Dni = 144444;
            objPersona4.Apellido = "Pereyra";

            Persona objPersona5 = new Persona() { Dni = 111, Apellido = "Sosa", Edad = 10 };

            objPersona3.Nombre = "Claudia";
            objPersona3.Edad = 30;

            objPersona1.Saludar(ConsoleColor.Blue);

            objPersona2.Saludar();

            objPersona2.SaludarNombreApellido();
        }

        public static void EjemploHerencia()
        {
            Figura figuraCirculo = new Circulo(4);
            Figura figuraCuadrado = new Cuadrado(10);

            figuraCirculo.CalcularArea();

            figuraCuadrado.CalcularArea();

            ((Circulo)figuraCirculo).Radio = 4;

            Circulo objNewCirculo = ((Circulo)figuraCirculo);

            Object objEjemplo = (Object)objNewCirculo;


            Rectangulo objRectangulo = new Rectangulo();

            objRectangulo.Lado1 = -5;
        }

        public static void EjemploColecciones()
        {
            List<string> lstPersonas = new List<string>();

            lstPersonas.Add("Juan");
            lstPersonas.Add("Pedro");
            lstPersonas.Add("Luis");
            lstPersonas.Add("Maria");


            for (int i = 0; i < lstPersonas.Count; i++)
            {
                Console.WriteLine(lstPersonas.ElementAt(i));
            }

        }

        public static void UsosClaseString()
        {

            // Comparacion strings
            bool esIgual = String.Equals("Palabra1", "Palabra2");

            string frase = "Hola, soy Juan";

            // Busqueda de palabra en frase
            bool resultadoBusqueda = frase.Contains("Juan");

            // Reemplazar texto
            string nuevaFrase = frase.Replace("Juan", "Pedro");

            // Eliminar espacios en blanco
            string fraseConEspacios = "    Hola Mundo     ";

            string palabraSinEspacios = fraseConEspacios.Trim();

            // Separar cadena de texto por caracter especial y devolverlo en un vector
            string personasCadena = "Juan,Pedro,Luis,Mario,Maria,Victor";

            string[] personas = personasCadena.Split(',');

        }






        public static void EjemplosSeguridadUsuarios()
        {
            Console.WriteLine("Ingrese su nombre usuario");

            Usuario objUsuario = new Usuario();

            objUsuario.NombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingrese su password");

            objUsuario.Password = Console.ReadLine();

            objUsuario.TipoUsuario = EnumTipoUsuario.Administrador;


            SeguridadUsuarios objSeguridadUsuario = new SeguridadUsuarios();

            bool resultado = objSeguridadUsuario.LoguearUsuario(objUsuario);


            if (resultado)
            {
                Console.WriteLine("Bienvenido");
            }
            else
            {
                Console.WriteLine("Fuera de aqui");
            }
        }

        public static void PruebasSeguridadII()
        {
            SeguridadUsuarios objSeguridad = new SeguridadUsuarios();

            string nombre = "Pablo";

            Usuario objUsuario = objSeguridad.BuscarUsuarioPorNombre(nombre);
        }

        public static void PruebaLogueoUsuarios()
        {
            UsuariosDatos objUsuariosDatos = new UsuariosDatos();

            Usuario objUsuario = new Usuario()
            {
                NombreUsuario = "Juan",
                Password = "123"
            };

            bool logueado = objUsuariosDatos.LoguearUsuario(objUsuario);

            Console.ReadKey();

        }



        #endregion

        static void Main(string[] args)
        {
           // DataTable dtUsuario = new UsuariosDatos().BuscarUsuarioDS(new Usuario() { NombreUsuario = "Juan" });

           // Usuario usuario = new UsuariosDatos().BuscarUsuario(new Usuario() { NombreUsuario = "Juan" });


            var objProducto = new { NombreProducto = "Pan", Precio = 300 };

            var cadenaTexto = "Cadena";


            cadenaTexto = "Cadena 2";

         


            var numeroEntero = 50;





            Console.ReadKey();
        }
    }
}
