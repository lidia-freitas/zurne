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

        public listaBicicleta()
        {
            InitializeComponent();
        }

        private void listarBicicletas(object sender, EventArgs e)
        {
            limparSelecao();
            dataGridBicicletas.DataSource = null;
            dataGridBicicletas.DataSource = serializeBicicletas();
        }

        private DataTable serializeBicicletas()
        {
            List<Bicicleta> listaBicicletasGrid = BicicletaController.ListarBicicletas();
            DataTable customTable = new DataTable("listaBicicletas");

            customTable.Columns.Add(new DataColumn("Id"));
            customTable.Columns.Add(new DataColumn("Marca"));
            customTable.Columns.Add(new DataColumn("Modelo"));
            customTable.Columns.Add(new DataColumn("Cor"));
            customTable.Columns.Add(new DataColumn("Ano"));
            customTable.Columns.Add(new DataColumn("Marchas"));

            foreach (Bicicleta bike in listaBicicletasGrid)
            {
                customTable.AcceptChanges();

                DataRow row = customTable.NewRow();
                row[0] = bike.Id;
                row[1] = bike.Marca;
                row[2] = bike.Modelo;
                row[3] = bike.Cor;
                row[4] = bike.Ano;
                row[5] = bike.Marchas;

                customTable.Rows.Add(row);
            }

            return customTable;
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
            dataGridBicicletas.DataSource = serializeBicicletas();

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
        }        
    }
}
