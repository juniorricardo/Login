using Entidades.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWF
{
    public partial class FrmCalculadora : Form
    {


        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            try
            {
                int numA = Convert.ToInt32(txtNumA.Text);
                int numB = Convert.ToInt32(txtNumB.Text);

                int Resultado = Calculadora.Sumar(numA, numB);

                txtResultado.Text = Resultado.ToString();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Hubo un error en el formato de los datos");
                     
            }
            catch(TimeoutException ex)
            {
                MessageBox.Show("No se puede conectar a la base");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la aplicacion");
            }
         

        }
    }
}
