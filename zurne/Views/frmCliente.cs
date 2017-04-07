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
        public Cliente clienteEdicao;

        public frmCliente()
        {
            InitializeComponent();
            limparCampos();            
        }

        public frmCliente(int _idCliente)
        {
            InitializeComponent();

            clienteId = _idCliente;
            carregarCliente();
        }

        private void carregarCliente()
        {            
            clienteEdicao = ClienteController.BuscarCliente(clienteId);

            //switch (clienteTipo)
            //{
            //    case "PF":
            //        textNome_PF.Text = clienteEdicao.Pessoa.Nomenclatura;
            //        textCpf_PF.Text = clienteEdicao.Pessoa.Documento;
            //       // textEmail_PF.Text = clienteEdicao.Pessoa.Email;
            //        //textEndereco_PF.Text = clienteEdicao.Pessoa.Endereco;

            //        rbPessoaFisica.Checked = true;
            //        rbPessoaJuridica.Checked = false;
            //        gbPessoaFiscia.Visible = true;
            //        gbPessoaJuridica.Visible = false;
            //        break;

            //    case "PJ":
            //        textRazaoSocial_PJ.Text = clienteEdicao.Pessoa.Nomenclatura;
            //        textCnpj_PJ.Text = clienteEdicao.Pessoa.Documento;
            //        //textContato_PJ.Text = clienteEdicao.PessoaJuridica.Contato;
            //       // textEmail_PJ.Text = clienteEdicao.Pessoa.Email;
            //       // textEndereco_PF.Text = clienteEdicao.Pessoa.Endereco;

            //        rbPessoaFisica.Checked = true;
            //        rbPessoaJuridica.Checked = false;
            //        gbPessoaFiscia.Visible = true;
            //        gbPessoaJuridica.Visible = false;
            //        break;
            //}
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
                        PessoaFisica pf = new PessoaFisica(textNome_PF.Text, textCpf_PF.Text,textEmail_PF.Text, textEndereco_PF.Text);
                        Cliente clienteCadatro = new Cliente(pf);                        

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
                        PessoaJuridica pj = new PessoaJuridica(textRazaoSocial_PJ.Text, textCnpj_PJ.Text, textEmail_PJ.Text, textEndereco_PJ.Text);
                        Cliente clienteCadastro = new Cliente(pj);

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
