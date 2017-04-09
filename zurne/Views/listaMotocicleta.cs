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
    public partial class listaMotocicleta : Form
    {
        private string idSelecionado;

        private List<Motocicleta> listaMotocicletasGrid = MotocicletaController.ListarMotocicletas();
        
        public listaMotocicleta()
        {
            InitializeComponent();
        }

        private void listarMotocicletas(object sender, EventArgs e)
        {
            limparSelecao();
            dataGridMotocicletas.DataSource = null;
            dataGridMotocicletas.DataSource = listaMotocicletasGrid;
        }

        private void cadastrarMotocicleta(object sender, EventArgs e)
        {
            frmMotocicleta frmMotocicleta = new frmMotocicleta();
            frmMotocicleta.MdiParent = this.MdiParent;

            frmMotocicleta.Show();
            frmMotocicleta.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void editarMotocicleta(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione uma motocicleta na lista");
                return;
            }

            frmMotocicleta frmMotocicleta = new frmMotocicleta(idSelecionado);
            frmMotocicleta.MdiParent = this.MdiParent;

            frmMotocicleta.Show();
            frmMotocicleta.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void removerMotocicleta(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione uma motocicleta na lista");
                return;
            }

            int motoID = Convert.ToInt32(idSelecionado);
            BicicletaController.RemoverBicicleta(motoID);

            dataGridMotocicletas.DataSource = null;
            dataGridMotocicletas.DataSource = listaMotocicletasGrid;

            MessageBox.Show("A motocicleta foi removida com sucesso!");

            limparSelecao();
        }

        private void limparSelecao()
        {
            idSelecionado = null;
        }

        private void selecionarMotocicleta(object sender, DataGridViewCellMouseEventArgs e)
        {
            idSelecionado = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
            Motocicleta moto = MotocicletaController.BuscarMotocicleta(Convert.ToInt32(idSelecionado));
        }        
    }
}
