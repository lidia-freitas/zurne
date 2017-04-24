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
    public partial class frmCliente : Form
    {
        private string idSelecionado;
        private string tipoSelecionado;

        public frmCliente()
        {
            InitializeComponent();
            limparCampos();            
        }

        public frmCliente(string _idCliente, string _tipoCliente)
        {
            InitializeComponent();

            idSelecionado = _idCliente;
            tipoSelecionado = _tipoCliente;

            carregarCliente();
        }

        private void carregarCliente()
        {
            int cliId = Convert.ToInt32(idSelecionado);         
            Cliente cli = ClienteController.BuscarCliente(cliId);
            rbPessoaFisica.Visible = false;
            rbPessoaJuridica.Visible = false;

            switch (tipoSelecionado)
            {
                case "PF":
                    textNome_PF.Text = cli.Pessoa.Nomenclatura;
                    textCpf_PF.Text = cli.Pessoa.Documento;
                    textEmail_PF.Text = cli.Pessoa.Email;
                    textEndereco_PF.Text = cli.Pessoa.Endereco;
                    
                    gbPessoaFiscia.Visible = true;
                    gbPessoaJuridica.Visible = false;
                    break;

                case "PJ":
                    textRazaoSocial_PJ.Text = cli.Pessoa.Nomenclatura;
                    textCnpj_PJ.Text = cli.Pessoa.Documento;
                    textEmail_PJ.Text = cli.Pessoa.Email;
                    textEndereco_PJ.Text = cli.Pessoa.Endereco;
                    
                    gbPessoaFiscia.Visible = false;
                    gbPessoaJuridica.Visible = true;
                    break;
            }
        }

        private void mostraFormPessoaFisica(object sender, EventArgs e)
        {
            gbPessoaFiscia.Visible = true;
            gbPessoaJuridica.Visible = false;
            tipoSelecionado = "PF";
        }

        private void mostraFormPessoaJuridica(object sender, EventArgs e)
        {
            gbPessoaFiscia.Visible = false;
            gbPessoaJuridica.Visible = true;
            tipoSelecionado = "PJ";
        }
      
        private void salvarCliente(Object sender, EventArgs e)
        {
            bool formularioValido = false;

            switch (tipoSelecionado)
            {
                case "PF":
                    if (string.IsNullOrEmpty(textNome_PF.Text) || string.IsNullOrEmpty(textCpf_PF.Text) ||
                    string.IsNullOrEmpty(textEmail_PF.Text) || string.IsNullOrEmpty(textEndereco_PF.Text))
                    {
                        MessageBox.Show("Todos campos são obrigatórios");
                        return;
                    }

                    formularioValido = true;
                    break;

                case "PJ":
                    if (string.IsNullOrEmpty(textRazaoSocial_PJ.Text) || string.IsNullOrEmpty(textCnpj_PJ.Text) ||
                    string.IsNullOrEmpty(textEmail_PJ.Text) || string.IsNullOrEmpty(textEndereco_PJ.Text))
                    {
                        MessageBox.Show("Todos campos são obrigatórios");
                        return;
                    }

                    formularioValido = true;
                    break;
            }

            if (!formularioValido) return;

            if (idSelecionado == null)
            {
                cadastrarCliente();
            }
            else
            {
                editarCliente();
            }   
        }

        private void cadastrarCliente()
        {
            switch (tipoSelecionado)
            {
                case "PF":
                    PessoaFisica pf = new PessoaFisica();
                    pf.Nome = textNome_PF.Text;
                    pf.CPF = textCpf_PF.Text;
                    pf.Email = textEmail_PF.Text;
                    pf.Endereco = textEndereco_PF.Text;  
                    
                    Cliente clientePF = new Cliente();
                    clientePF.Pessoa = pf;                    

                    ClienteController.CadastrarCliente(clientePF);
                    break;

                case "PJ":
                    PessoaJuridica pj = new PessoaJuridica();
                    pj.RazaoSocial = textRazaoSocial_PJ.Text;
                    pj.Email = textEmail_PJ.Text;
                    pj.CNPJ = textCnpj_PJ.Text;
                    pj.Endereco = textEndereco_PJ.Text;

                    Cliente clientePJ = new Cliente();
                    clientePJ.Pessoa = pj;

                    ClienteController.CadastrarCliente(clientePJ);
                    break;   
            }

            MessageBox.Show("Cliente cadastrado com sucesso!");
            limparCampos();
        }

        private void editarCliente()
        {
            int cliId = Convert.ToInt32(idSelecionado);

            switch (tipoSelecionado)
            {
                case "PF":
                    ClienteController.EditarCliente(cliId, textNome_PF.Text, textCpf_PF.Text, textEmail_PF.Text, textEndereco_PF.Text);
                    break;

                case "PJ":
                    ClienteController.EditarCliente(cliId, textRazaoSocial_PJ.Text, textCnpj_PJ.Text, textEmail_PJ.Text, textEndereco_PJ.Text);
                    break;
            }

            MessageBox.Show("Cliente editado com sucesso!");            
        }
        
        private void limparCampos()
        {
            textRazaoSocial_PJ.Clear(); 
            textCnpj_PJ.Clear();
            textEmail_PJ.Clear();
            textEndereco_PJ.Clear();

            textNome_PF.Clear();
            textCpf_PF.Clear();
            textEmail_PF.Clear();
            textEndereco_PF.Clear();
        }

        private void voltar(object sender, EventArgs e)
        {
            listaCliente listaCliente = new listaCliente();
            listaCliente.MdiParent = this.MdiParent;

            listaCliente.Show();
            listaCliente.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
