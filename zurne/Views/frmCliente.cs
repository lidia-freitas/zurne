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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            gbPessoaFiscia.Visible = true;
            gbPessoaJuridica.Visible = false;
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            gbPessoaFiscia.Visible = false;
            gbPessoaJuridica.Visible = true;
        }

        private void gbPessoalFiscia_Enter(object sender, EventArgs e)
        {

        }

        private void gbPessoaJuridica_Enter(object sender, EventArgs e)
        {

        }
    }
}
