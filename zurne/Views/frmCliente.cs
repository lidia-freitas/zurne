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
        public string clienteTipo;

        public frmCliente(int? _idCliente, string _tipoCliente)
        {
            InitializeComponent();

            if (_idCliente.HasValue)
            {
                clienteId = _idCliente;                
            }
                           
            clienteTipo = _tipoCliente;
            
        }

        private void carregarCliente(object sender, EventArgs e)
        {
            if (clienteId.HasValue)
            {
                if (clienteTipo == "F") {
                    carregarPessoaFisica();
                }
                else if (clienteTipo == "J") {
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
            PessoaFisica cli = new PessoaFisica();
            cli = ClienteController.BuscarPF(clienteId);

            if (cli != null)
            {
                textNome_PF.Text = cli.Nome;
                textCpf_PF.Text = cli.CPF;
                textEmail_PF.Text = cli.Email;
                textEndereco_PF.Text = cli.Endereco;
            }

            rbPessoaFisica.Checked = true;
            rbPessoaJuridica.Checked = false;
            gbPessoaFiscia.Visible = true;
            gbPessoaJuridica.Visible = false;
        }

        private void carregarPessoaJuridica()
        {

            PessoaJuridica cli = new PessoaJuridica();

            cli = ClienteController.BuscarPJ(clienteId);

            if(cli != null)
            {
                textRazaoSocial_PJ.Text = cli.RazaoSocial;
                textCnpj_PJ.Text = cli.CNPJ;
                textContato_PJ.Text = cli.Contato;
                textEmail_PJ.Text = cli.Email;
                textEndereco_PF.Text = cli.Endereco;
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
            ClienteController.CadastrarPf(textNome_PF.Text, textCpf_PF.Text, textEmail_PF.Text, textEndereco_PF.Text);
                      
            MessageBox.Show("Cliente cadastrado com sucesso!");

            limparCampos();           

        }

        private void salvarPessoaJuridica(object sender, EventArgs e)
        {

            ClienteController.CadastrarPj(textRazaoSocial_PJ.Text, textCnpj_PJ.Text, textContato_PJ.Text, textEmail_PJ.Text, textEndereco_PJ.Text );

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
            listaCliente listaCliente = new listaCliente();

            listaCliente.MdiParent = this.MdiParent;

            listaCliente.Show();
            listaCliente.WindowState = FormWindowState.Maximized;

            this.Close();
        }
                
    }
}
