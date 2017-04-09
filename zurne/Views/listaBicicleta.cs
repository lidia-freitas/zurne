using Controllers;
using Models;
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
    public partial class listaBicicleta : Form
    {
        private string idSelecionado;

        private List<Bicicleta> listaBicicletasGrid = BicicletaController.ListarBicicletas();

        public listaBicicleta()
        {
            InitializeComponent();
        }

        private void listarBicicletas(object sender, EventArgs e)
        {
            limparSelecao();
            dataGridBicicletas.DataSource = null;
            dataGridBicicletas.DataSource = listaBicicletasGrid;
        }

        private void cadastrarBicicleta(object sender, EventArgs e)
        {
            frmBicicleta frmBicicleta = new frmBicicleta();
            frmBicicleta.MdiParent = this.MdiParent;

            frmBicicleta.Show();
            frmBicicleta.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void editarBicicleta(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione uma bicicleta na lista");
                return;
            }

            frmBicicleta frmBicicleta = new frmBicicleta(idSelecionado);
            frmBicicleta.MdiParent = this.MdiParent;

            frmBicicleta.Show();
            frmBicicleta.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void removerBicicleta(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione uma bicicleta na lista");
                return;
            }

            int bikeId = Convert.ToInt32(idSelecionado);
            BicicletaController.RemoverBicicleta(bikeId);

            dataGridBicicletas.DataSource = null;
            dataGridBicicletas.DataSource = listaBicicletasGrid;

            MessageBox.Show("A bicicleta foi removida com sucesso!");

            limparSelecao();
        }

        private void limparSelecao()
        {
            idSelecionado = null;
        }

        private void selecionarBicicleta(object sender, DataGridViewCellMouseEventArgs e)
        {
            idSelecionado = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
            Bicicleta bike = BicicletaController.BuscarBicicleta(Convert.ToInt32(idSelecionado));
        }

        
    }
}
