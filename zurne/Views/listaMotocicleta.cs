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
        
        public listaMotocicleta()
        {
            InitializeComponent();
        }

        private void listarMotocicletas(object sender, EventArgs e)
        {
            limparSelecao();
            dataGridMotocicletas.DataSource = null;
            dataGridMotocicletas.DataSource = serializeAutomoveis();
        }

        private DataTable serializeAutomoveis()
        {
            List<Motocicleta> listaMotocicletasGrid = MotocicletaController.ListarMotocicletas();
            DataTable customTable = new DataTable("listaMotocicletas");

            customTable.Columns.Add(new DataColumn("Id"));
            customTable.Columns.Add(new DataColumn("Marca"));
            customTable.Columns.Add(new DataColumn("Modelo"));
            customTable.Columns.Add(new DataColumn("Cor"));
            customTable.Columns.Add(new DataColumn("Ano"));
            customTable.Columns.Add(new DataColumn("Cilindradas"));
            customTable.Columns.Add(new DataColumn("Autonomia"));

            foreach (Motocicleta moto in listaMotocicletasGrid)
            {
                customTable.AcceptChanges();

                DataRow row = customTable.NewRow();
                row[0] = moto.Id;
                row[1] = moto.Marca;
                row[2] = moto.Modelo;
                row[3] = moto.Cor;
                row[4] = moto.Ano;
                row[5] = moto.Cilindradas;
                row[6] = moto.Autonomia;

                customTable.Rows.Add(row);
            }

            return customTable;
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
            MotocicletaController.RemoverMotocicleta(motoID);

            dataGridMotocicletas.DataSource = null;
            dataGridMotocicletas.DataSource = serializeAutomoveis();

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
        }        
    }
}
