using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;
    
namespace Views
{
    public partial class listaCliente : Form
    {
        private string idSelecionado;
        private string tipoSelecionado;

        private List<Cliente> listaClientesGrid = ClienteController.ListarClientes();

        public listaCliente()
        {
            InitializeComponent();
        }

        private void listarClientes(object sender, EventArgs e)
        {
            limparSelecao();
            dataGridClientes.DataSource = null;
            dataGridClientes.DataSource = serializeClientes(listaClientesGrid);
        }

        private DataTable serializeClientes(List<Cliente> listaClientes)
        {
            DataTable customTable = new DataTable("listaClientes");

            customTable.Columns.Add(new DataColumn("Id"));
            customTable.Columns.Add(new DataColumn("Nome/Razão Social"));
            customTable.Columns.Add(new DataColumn("CPF/CNPJ"));
            customTable.Columns.Add(new DataColumn("E-mail"));
            customTable.Columns.Add(new DataColumn("Endereço"));

            foreach (Cliente cli in listaClientes)
            {

                customTable.AcceptChanges();

                DataRow row = customTable.NewRow();
                row[0] = cli.Id;
                row[1] = cli.Pessoa.Nomenclatura;
                row[2] = cli.Pessoa.Documento;
                row[3] = cli.Pessoa.Email;
                row[4] = cli.Pessoa.Endereco;

                customTable.Rows.Add(row);
            }

            return customTable;

        }

        private void cadastrarCliente(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();            
            frmCliente.MdiParent = this.MdiParent;
            
            frmCliente.Show();
            frmCliente.WindowState = FormWindowState.Maximized;
            this.Close();
        }                          

        private void editarCliente(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um cliente na lista");
                return;
            } 

            frmCliente frmCliente = new frmCliente(idSelecionado, tipoSelecionado);
            frmCliente.MdiParent = this.MdiParent;

            frmCliente.Show();
            frmCliente.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void removerCliente(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um cliente na lista");
                return;
            }

            int cliId = Convert.ToInt32(idSelecionado);            
            ClienteController.RemoverCliente(cliId);

            dataGridClientes.DataSource = null;
            dataGridClientes.DataSource = serializeClientes(listaClientesGrid);

            MessageBox.Show("O cliente foi removido com sucesso!");

            limparSelecao();
        }     

        private void limparSelecao()
        {
            idSelecionado = null;
            tipoSelecionado = null;
        }

        private void selecionarCliente(object sender, DataGridViewCellMouseEventArgs e)
        {               
            idSelecionado = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
            Cliente cli = ClienteController.BuscarCliente(Convert.ToInt32(idSelecionado));

            if (cli.Pessoa is PessoaFisica)
            {
                tipoSelecionado = "PF";
            }
            else
            {
                tipoSelecionado = "PJ";
            }
        }      
    }        
}
 