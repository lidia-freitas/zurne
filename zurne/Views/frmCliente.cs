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
        public int clienteId;
        public string clienteTipo;
        public Cliente clienteEdicao;

        public frmCliente()
        {
            InitializeComponent();
            limparCampos();            
        }

        public frmCliente(int _idCliente, string _tipoCliente)
        {
            InitializeComponent();

            clienteId = _idCliente;
            clienteTipo = _tipoCliente;
            carregarCliente();
        }

        private void carregarCliente()
        {            
            clienteEdicao = ClienteController.BuscarCliente(clienteId);

            switch (clienteTipo)
            {
                case "PF":
                    textNome_PF.Text = clienteEdicao.PessoaFisica.Nome;
                    textCpf_PF.Text = clienteEdicao.PessoaFisica.CPF;
                    textEmail_PF.Text = clienteEdicao.PessoaFisica.Email;
                    textEndereco_PF.Text = clienteEdicao.PessoaFisica.Endereco;

                    rbPessoaFisica.Checked = true;
                    rbPessoaJuridica.Checked = false;
                    gbPessoaFiscia.Visible = true;
                    gbPessoaJuridica.Visible = false;
                    break;

                case "PJ":
                    textRazaoSocial_PJ.Text = clienteEdicao.PessoaJuridica.RazaoSocial;
                    textCnpj_PJ.Text = clienteEdicao.PessoaJuridica.CNPJ;
                    textContato_PJ.Text = clienteEdicao.PessoaJuridica.Contato;
                    textEmail_PJ.Text = clienteEdicao.PessoaJuridica.Email;
                    textEndereco_PF.Text = clienteEdicao.PessoaJuridica.Endereco;

                    rbPessoaFisica.Checked = true;
                    rbPessoaJuridica.Checked = false;
                    gbPessoaFiscia.Visible = true;
                    gbPessoaJuridica.Visible = false;
                    break;
            }
        }

        private void mostraFormPessoaFisica(object sender, EventArgs e)
        {
            gbPessoaFiscia.Visible = true;
            gbPessoaJuridica.Visible = false;
        }

        private void mostraFormPessoaJuridica(object sender, EventArgs e)
        {
            gbPessoaFiscia.Visible = false;
            gbPessoaJuridica.Visible = true;
        }
      
        private void salvarCliente(Object sender, EventArgs e)
        {
            if (gbPessoaFiscia.Visible == true)
            {
                if (string.IsNullOrEmpty(textNome_PF.Text) || string.IsNullOrEmpty(textCpf_PF.Text) ||
                    string.IsNullOrEmpty(textEmail_PF.Text) || string.IsNullOrEmpty(textEndereco_PF.Text))
                {
                    MessageBox.Show("Todos campos são obrigatórios");
                }
                else
                {
                    if (clienteEdicao != null)
                    {
                        ClienteController.EditarCliente(clienteEdicao);
                    }
                    else
                    {
                        Cliente clienteCadatro = new Cliente();
                        PessoaFisica pf = new PessoaFisica();

                        pf.Nome = textNome_PF.Text;
                        pf.CPF = textCpf_PF.Text;
                        pf.Email = textEmail_PF.Text;
                        pf.Endereco = textEndereco_PF.Text;

                        clienteCadatro.PessoaFisica = pf;

                        ClienteController.CadastrarCliente(clienteCadatro);
                        MessageBox.Show("Cliente cadastrado com sucesso!");
                        limparCampos();
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textRazaoSocial_PJ.Text) || string.IsNullOrEmpty(textCnpj_PJ.Text) || string.IsNullOrEmpty(textContato_PJ.Text) ||
                    string.IsNullOrEmpty(textEmail_PJ.Text) || string.IsNullOrEmpty(textEndereco_PJ.Text))
                {
                    MessageBox.Show("Todos campos são obrigatórios");
                }
                else
                { 
                    if (clienteEdicao != null)
                        {
                            ClienteController.EditarCliente(clienteEdicao);
                        }
                    else
                    {
                        Cliente clienteCadastro = new Cliente();
                        PessoaJuridica pj = new PessoaJuridica();

                        pj.RazaoSocial = textRazaoSocial_PJ.Text;
                        pj.CNPJ = textCnpj_PJ.Text;
                        pj.Contato = textContato_PJ.Text;
                        pj.Email = textEmail_PJ.Text;
                        pj.Endereco = textEndereco_PJ.Text;

                        clienteCadastro.PessoaJuridica = pj;
                        ClienteController.CadastrarCliente(clienteCadastro);

                        MessageBox.Show("Cliente cadastrado com sucesso!");
                        limparCampos();
                    }
                }
            }
        }

        private void limparCampos()
        {
            textRazaoSocial_PJ.Clear(); 
            textCnpj_PJ.Clear();
            textContato_PJ.Clear();
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
