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

        public listaAutomovel()
        {
            InitializeComponent();
        }

        private void listarAutomoveis(object sender, EventArgs e)
        {
            limparSelecao();
            dataGridAutomoveis.DataSource = null;
            dataGridAutomoveis.DataSource = serializeAutomoveis();
        }

        private DataTable serializeAutomoveis()
        {
            List<Automovel> listaAutomoveisGrid = AutomovelController.ListarAutomoveis();
            DataTable customTable = new DataTable("listaBicicletas");

            customTable.Columns.Add(new DataColumn("Id"));
            customTable.Columns.Add(new DataColumn("Marca"));
            customTable.Columns.Add(new DataColumn("Modelo"));
            customTable.Columns.Add(new DataColumn("Cor"));
            customTable.Columns.Add(new DataColumn("Ano"));
            customTable.Columns.Add(new DataColumn("Potencia"));
            customTable.Columns.Add(new DataColumn("Autonomia"));

            foreach (Automovel auto in listaAutomoveisGrid)
            {
                customTable.AcceptChanges();

                DataRow row = customTable.NewRow();
                row[0] = auto.Id;
                row[1] = auto.Marca;
                row[2] = auto.Modelo;
                row[3] = auto.Cor;
                row[4] = auto.Ano;
                row[5] = auto.Potencia;
                row[6] = auto.Autonomia;

                customTable.Rows.Add(row);
            }

            return customTable;
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
                MessageBox.Show("Por favor, selecione um automóvel na lista");
                return;
            }

            int autoId = Convert.ToInt32(idSelecionado);
            AutomovelController.RemoverAutomovel(autoId);

            dataGridAutomoveis.DataSource = null;
            dataGridAutomoveis.DataSource = serializeAutomoveis(); ;

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
        }
    }
}
