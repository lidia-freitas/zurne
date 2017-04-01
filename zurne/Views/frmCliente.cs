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
        public int? clienteId;
        public int? clienteTipo;

        public frmCliente(int? _idCliente, int? _tipoCliente)
        {
            InitializeComponent();

            if (_idCliente.HasValue)
            {
                clienteId = _idCliente;                
            }

            if (_tipoCliente.HasValue)
            {                
                clienteTipo = _tipoCliente;
            }
        }

        private void carregarCliente(object sender, EventArgs e)
        {
            if (clienteId.HasValue)
            {
                if (clienteTipo == 0) {
                    carregarPessoaFisica();
                }
                else if (clienteTipo == 1) {
                    carregarPessoaJuridica();
                }
            }
            else
            {
                limparCampos();
            }
        }

        private void carregarPessoaFisica()
        {
            ClienteController cliController = new ClienteController();
            PessoaFisica pf = new PessoaFisica();
            Cliente cli = new Cliente(pf);

            cli = cliController.Buscar(clienteId);

            if (cli != null)
            {
                textNome_PF.Text = cli.PessoaFisica.Nome;
                textCpf_PF.Text = cli.PessoaFisica.CPF;
                textEmail_PF.Text = cli.PessoaFisica.Email;
                textEndereco_PF.Text = cli.PessoaFisica.Endereco;
            }

            rbPessoaFisica.Checked = true;
            rbPessoaJuridica.Checked = false;
            gbPessoaFiscia.Visible = true;
            gbPessoaJuridica.Visible = false;
        }

        private void carregarPessoaJuridica()
        {
            ClienteController cliController = new ClienteController();
            PessoaJuridica pj = new PessoaJuridica();
            Cliente cli = new Cliente(pj);

            cli = cliController.Buscar(clienteId);

            if(cli != null)
            {
                textRazaoSocial_PJ.Text = cli.PessoaJuridica.RazaoSocial;
                textCnpj_PJ.Text = cli.PessoaJuridica.CNPJ;
                textContato_PJ.Text = cli.PessoaJuridica.Contato;
                textEmail_PJ.Text = cli.PessoaJuridica.Email;
                textEndereco_PF.Text = cli.PessoaJuridica.Endereco;
            }

            rbPessoaFisica.Checked = true;
            rbPessoaJuridica.Checked = false;
            gbPessoaFiscia.Visible = true;
            gbPessoaJuridica.Visible = false;
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
       

        private void salvarPessoaFisica(object sender, EventArgs e)
        {
            ClienteController cliController = new ClienteController();            

            cliController.CadastrarPf(textNome_PF.Text, textCpf_PF.Text, textEmail_PF.Text, textEndereco_PF.Text);

            MessageBox.Show("Cliente cadastrado com sucesso!");

            limparCampos();
        }

        private void salvarPessoaJuridica(object sender, EventArgs e)
        {
            ClienteController cliController = new ClienteController();

            cliController.CadastrarPj(textRazaoSocial_PJ.Text, textCnpj_PJ.Text, textContato_PJ.Text, textEmail_PJ.Text, textEndereco_PJ.Text );

            MessageBox.Show("Cliente cadastrado com sucesso!");

            limparCampos();

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

        private void cancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
