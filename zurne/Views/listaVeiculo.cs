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
    public partial class listaVeiculo : Form
    {
        public listaVeiculo()
        {
            InitializeComponent();
        }

        private void listarVeiculos(object sender, EventArgs e)
        {

        }
              

        private void cadastrarVeiculo(object sender, EventArgs e)
        {
            frmVeiculo frmVeiculo = new frmVeiculo();
            frmVeiculo.MdiParent = this.MdiParent;

            frmVeiculo.Show();
            frmVeiculo.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void editarVeiculo(object sender, EventArgs e)
        {

        }

        private void removerVeiculo(object sender, EventArgs e)
        {

        }

        private void selecionarVeiculo(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
