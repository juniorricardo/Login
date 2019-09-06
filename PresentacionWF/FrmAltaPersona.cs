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
    public partial class FrmAltaPersona : Form
    {
        public FrmAltaPersona()
        {
            InitializeComponent();
        }

        public void LimpiarFormulario()
        {
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtDni.Text = String.Empty;
            txtEdad.Text = String.Empty;
        }


        public bool ValidarFormulario()
        {
            eprErrores.Clear();

            bool validado = true;
            
            //if (txtApellido.Text == "" || txtApellido.Text == null)
            if (String.IsNullOrEmpty(txtApellido.Text))
            {
                eprErrores.SetError(txtApellido, "Campo apellido requerido");
                validado = false;
            }




            return validado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarFormulario())
                {
                    Persona objPersona = new Persona();

                    objPersona.Dni = Convert.ToInt32(txtDni.Text);
                    objPersona.Apellido = txtApellido.Text;
                    objPersona.Nombre = txtNombre.Text;
                    objPersona.Edad = Convert.ToInt32(txtEdad.Text);
                    objPersona.Direccion = txtDireccion.Text;

                    new PersonasNegocio().AgregarPersona(objPersona);

                    MessageBox.Show("La operacion finalizo correctamente");
                    this.LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Verifique los errores en el formulario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error. Detalle: " + ex.Message);
            }

        }
    }
}
