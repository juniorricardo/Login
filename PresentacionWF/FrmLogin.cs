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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {

                SeguridadUsuarios objSeguridad = new SeguridadUsuarios();

                UsuariosNegocio objUsuariosNegocio = new UsuariosNegocio();

                Usuario objUsuario = new Usuario();
                objUsuario.NombreUsuario = txtUsuario.Text;
                objUsuario.Password = txtPassword.Text;

                //bool logueado = objSeguridad.LoguearUsuario(objUsuario);

                bool logueado = objUsuariosNegocio.LoguearUsuario(objUsuario);

                if (logueado)
                {

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario no valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error. Detalle: " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
