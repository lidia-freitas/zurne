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
    public partial class listaAutomovel : Form
    {
        private string idSelecionado;

        private List<Automovel> listaAutomoveisGrid = AutomovelController.ListarAutomoveis();

        public listaAutomovel()
        {
            InitializeComponent();
        }

        private void listarAutomoveis(object sender, EventArgs e)
        {
        limparSelecao();
        dataGridAutomoveis.DataSource = null;
        dataGridAutomoveis.DataSource = listaAutomoveisGrid;
        }

        private void cadastrarAutomovel(object sender, EventArgs e)
        {
            frmAutomovel frmAutomovel = new frmAutomovel();
            frmAutomovel.MdiParent = this.MdiParent;

            frmAutomovel.Show();
            frmAutomovel.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void editarAutomovel(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um automóvel na lista");
                return;
            }

            frmAutomovel frmAutomovel = new frmAutomovel(idSelecionado);
            frmAutomovel.MdiParent = this.MdiParent;

            frmAutomovel.Show();
            frmAutomovel.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void removerAutomovel(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um automovel na lista");
                return;
            }

            int autoId = Convert.ToInt32(idSelecionado);
            AutomovelController.RemoverAutomovel(autoId);

            dataGridAutomoveis.DataSource = null;
            dataGridAutomoveis.DataSource = listaAutomoveisGrid;

            MessageBox.Show("O automóvel foi removido com sucesso!");

            limparSelecao();
        }

        private void limparSelecao()
        {
            idSelecionado = null;
        }

        private void selecionarAutomovel(object sender, DataGridViewCellMouseEventArgs e)
        {
            idSelecionado = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
            Automovel auto = AutomovelController.BuscarAutomovel(Convert.ToInt32(idSelecionado));
        }
    }
}
