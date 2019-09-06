using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Negocio
{
    public class UsuariosNegocio
    {
        public bool LoguearUsuario(Usuario usuario)
        {
            /*
            if(usuario.Edad < 21){

                    throw new Exception ("El usuario es menor de edad");
            }
            */

            return (new UsuariosDatos().LoguearUsuario(usuario));



        }

        public List<Usuario> ListarUsuarios()
        {
            return (new UsuariosDatos().ListarUsuarios());
        }

        public void AgregarUsuario(Usuario usuario)
        {
            // Validaciones:
            // Existe o no
            // Password no cumple con politicas de seguridad
            // Usuario menor a 18.
            
             new UsuariosDatos().AgregarUsuario(usuario);


        }
    }
}
