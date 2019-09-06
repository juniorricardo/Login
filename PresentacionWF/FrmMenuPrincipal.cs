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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCalculadora().ShowDialog();
        }

        private void listarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().Show();
        }

        private void agregarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAltaPersona().ShowDialog();
        }

        private void listarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmReportePersonas().Show();
        }
    }
}
