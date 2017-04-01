using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void abrirFormCliente(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente(null, null);
            frmCliente.MdiParent = this;
            frmCliente.Show();
            frmCliente.WindowState = FormWindowState.Maximized;
        }

        private void abrirFormFuncionario(object sender, EventArgs e)
        {

        }
    }
}
