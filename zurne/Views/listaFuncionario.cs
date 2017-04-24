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
    public partial class listaFuncionario : Form
    {
        private string idSelecionado;
        private string tipoSelecionado;

        public listaFuncionario()
        {
            InitializeComponent();
        }

        private void listarFuncionarios(object sender, EventArgs e)
        {
            limparSelecao();
            dataGridFuncionarios.DataSource = null;
            dataGridFuncionarios.DataSource = serializeFuncionarios();
        }

        private DataTable serializeFuncionarios()
        {
            List<Funcionario> listaFuncionariosGrid = FuncionarioController.ListarFuncionarios();
            DataTable customTable = new DataTable("listaFuncionarios");

            customTable.Columns.Add(new DataColumn("Id"));
            customTable.Columns.Add(new DataColumn("Nome/Razão Social"));
            customTable.Columns.Add(new DataColumn("CPF/CNPJ"));
            customTable.Columns.Add(new DataColumn("E-mail"));
            customTable.Columns.Add(new DataColumn("Endereço"));

            foreach (Funcionario func in listaFuncionariosGrid)
            {
                customTable.AcceptChanges();

                DataRow row = customTable.NewRow();
                row[0] = func.PessoaId;
                row[1] = func.Pessoa.Nomenclatura;
                row[2] = func.Pessoa.Documento;
                row[3] = func.Pessoa.Email;
                row[4] = func.Pessoa.Endereco;

                customTable.Rows.Add(row);
            }

            return customTable;

        }

        private void cadastrarFuncionario(object sender, EventArgs e)
        {
            frmFuncionario frmFuncionario = new frmFuncionario();
            frmFuncionario.MdiParent = this.MdiParent;

            frmFuncionario.Show();
            frmFuncionario.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void editarFuncionario(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um funcionario na lista");
                return;
            }

            frmFuncionario frmFuncionario = new frmFuncionario(idSelecionado, tipoSelecionado);
            frmFuncionario.MdiParent = this.MdiParent;

            frmFuncionario.Show();
            frmFuncionario.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void removerFuncionario(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um funcionario na lista");
                return;
            }

            int funcId = Convert.ToInt32(idSelecionado);
            FuncionarioController.RemoverFuncionario(funcId);

            dataGridFuncionarios.DataSource = null;
            dataGridFuncionarios.DataSource = serializeFuncionarios();

            MessageBox.Show("O funcionario foi removido com sucesso!");

            limparSelecao();
        }

        private void limparSelecao()
        {
            idSelecionado = null;
            tipoSelecionado = null;
        }

        private void selecionarFuncionario(object sender, DataGridViewCellMouseEventArgs e)
        {
            idSelecionado = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
            Funcionario func = FuncionarioController.BuscarFuncionario(Convert.ToInt32(idSelecionado));

            if (func.Pessoa is PessoaFisica)
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
