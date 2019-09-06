using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace PresentacionWF
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            RefrescarGrilla();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            try
            {
                new UsuariosNegocio().AgregarUsuario(usuario);
                RefrescarGrilla();

                MessageBox.Show("El usuario se agrego correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error" + ex.Message);
            }
        }

        public void RefrescarGrilla()
        {
            dgvUsuarios.DataSource = null;

            List<Usuario> lstUsuarios = new UsuariosNegocio().ListarUsuarios();

            var coleccion =  (from u in lstUsuarios
                                      where u.NombreUsuario == "Juan"
                                      orderby u.NombreUsuario
                                      select new
                                      {
                                          NombreUsuario = u.NombreUsuario,
                                          Password = u.Password,
                                          Jerarquia = "Senior"
                                      }).ToList();
        }
    }
}
