using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class SeguridadUsuarios
    {
        //Atributo (o variable de clase) donde guardo los usuarios validos.
        private List<Usuario> lstUsuariosValidos = new List<Usuario>();


        public SeguridadUsuarios()
        {
            // Defino objetos
            Usuario usuario1 = new Usuario() { NombreUsuario = "Juan", Password = "123" };

            Usuario usuario2 = new Usuario();
            usuario2.NombreUsuario = "Maria";
            usuario2.Password = "123";

            Usuario usuario3 = new Usuario();
            usuario3.NombreUsuario = "Luis";
            usuario3.Password = "123";

            // Agrego elementos a la coleccion

            lstUsuariosValidos.Add(usuario1);
            lstUsuariosValidos.Add(usuario2);
            lstUsuariosValidos.Add(usuario3);

            lstUsuariosValidos.Add(new Usuario() { NombreUsuario = "Pepe", Password = "111" });


        }


        public bool LoguearUsuario(Usuario _usuario)
        {
            for (int i = 0; i < lstUsuariosValidos.Count; i++)
            {
                if (_usuario.NombreUsuario == lstUsuariosValidos.ElementAt(i).NombreUsuario
                    && _usuario.Password == lstUsuariosValidos.ElementAt(i).Password
                    )
                {
                    return true;
                }

            }

            return false;

        }

        public void AgregarUsuario(Usuario _usuario)
        {
            lstUsuariosValidos.Add(_usuario);

            var listado = (from p in lstUsuariosValidos
                           where p.NombreUsuario == "Juan" select new {Nombre = p.NombreUsuario, Tipo = "Unico" }).ToList();

        }




        // BuscarUsuarioPorNombre(string nombreUsuario): Usuario

        public Usuario BuscarUsuarioPorNombre(string nombreUsuario)
        {
            for (int i = 0; i < lstUsuariosValidos.Count; i++)
            {
                if (nombreUsuario == lstUsuariosValidos.ElementAt(i).NombreUsuario)
                {
                    return lstUsuariosValidos.ElementAt(i);
                }
            }

            return null;
        }

        public Usuario ObtenerUsuarioLinq(string usuario)
        {
            var objUsuario = (from u in lstUsuariosValidos
                              where u.NombreUsuario == usuario
                              select u
                               ).FirstOrDefault();

            return objUsuario;
        }

        public List<Usuario> ListarUsuarioLinq(EnumTipoUsuario tipo)
        {
            var lstUsuario = (from u in lstUsuariosValidos
                              where u.TipoUsuario == tipo
                              select u
                               ).ToList();

            var lstUsuario2 = lstUsuario.Where(p => p.TipoUsuario == tipo).ToList();

            //var idMax = lstUsuario.Max(p => p.IdUsuario);

            return lstUsuario;
        }

    }
}
