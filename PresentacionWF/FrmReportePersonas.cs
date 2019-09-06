using Negocio;
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
    public partial class FrmReportePersonas : Form
    {
        public FrmReportePersonas()
        {
            InitializeComponent();

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = new PersonasNegocio().ListarPersonasDS();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            new PersonasNegocio().ActualizarPersonasDs((DataTable)dgvPersonas.DataSource);
        }
    }
}
