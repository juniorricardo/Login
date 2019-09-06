using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario: IMostrable
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public EnumTipoUsuario TipoUsuario { get; set; }
        public bool Habilitado { get; set; }


        public string MostrarDatos()
        {
            return ("Nombre: " + NombreUsuario + " Password: " + Password);
        }
    }
}
