using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public class UsuariosDatos
    {

        public bool LoguearUsuario(Usuario usuario)
        {
            SqlConnection objConnection = null;
            SqlCommand objSqlCommand = null;

            try
            {
                
                objConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);

                objSqlCommand = new SqlCommand(@"select count(*) 
                                                        from Usuarios 
                                                        where NombreUsuario = @nombreUsuario
                                                        and Password = @password", objConnection);

                objSqlCommand.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                objSqlCommand.Parameters.AddWithValue("@password", usuario.Password);


                if (objConnection.State != System.Data.ConnectionState.Open)
                {
                    objConnection.Open();
                }


                int count = (int)objSqlCommand.ExecuteScalar();




                //return (count > 0);

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error SQL");
            }
            finally
            {
                if (objConnection.State != System.Data.ConnectionState.Closed)
                {
                    objConnection.Close();
                }
            }
        }

        public List<Usuario> ListarUsuarios()
        {
            SqlConnection objConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);

            SqlCommand objSqlCommand = new SqlCommand("select * from Usuarios", objConnection);

            objConnection.Open();

            SqlDataReader objReader = objSqlCommand.ExecuteReader();

            List<Usuario> lstUsuarios = new List<Usuario>();

            while (objReader.Read())
            {
                Usuario objUsuario = new Usuario();
                objUsuario.NombreUsuario = objReader["NombreUsuario"].ToString();
                objUsuario.Password = objReader["Password"].ToString();

                lstUsuarios.Add(objUsuario);
            }

            objConnection.Close();

            return lstUsuarios;
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            SqlConnection objConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);

            SqlCommand objSqlCommand = new SqlCommand("exec SP_BuscarUsuario @NombreUsuario", objConnection);

          //  objSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;


            objSqlCommand.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
            
            objConnection.Open();

            SqlDataReader objReader = objSqlCommand.ExecuteReader();
            Usuario objUsuario = new Usuario();

            if (objReader.Read())
            {
                objUsuario.NombreUsuario = objReader["NombreUsuario"].ToString();
                objUsuario.Password = objReader["Password"].ToString();
            }
                         

            objConnection.Close();

            return objUsuario;
        }





        public DataTable BuscarUsuarioDS(Usuario usuario)
        {
           return (DataTable) new ProgramacionNetDSTableAdapters.UsuariosTableAdapter().BuscarUsuarioDS(usuario.NombreUsuario);
        }






        public void AgregarUsuario(Usuario usuario)
        {
            SqlConnection objConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);

            SqlCommand objSqlCommand = new SqlCommand("insert into Usuarios values (@usuario,@Password,1)",objConnection);

            objSqlCommand.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
            objSqlCommand.Parameters.AddWithValue("@password", usuario.Password);

            // Validar apertura
            objConnection.Open();
               

            objSqlCommand.ExecuteNonQuery();
           
            // Validar cierre
            objConnection.Close();
            
        }



    }
}
