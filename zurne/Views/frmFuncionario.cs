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
    public partial class frmFuncionario : Form
    {
        private string idSelecionado;
        private string tipoSelecionado;

        public frmFuncionario()
        {
            InitializeComponent();
            limparCampos();
        }

        public frmFuncionario(string _idFuncionario, string _tipoFuncionario)
        {
            InitializeComponent();

            idSelecionado = _idFuncionario;
            tipoSelecionado = _tipoFuncionario;

            carregarFuncionario();
        }

        private void carregarFuncionario()
        {
            int funcId = Convert.ToInt32(idSelecionado);
            Funcionario func = FuncionarioController.BuscarFuncionario(funcId);
            //rbPessoaFisica.Visible = false;
            //rbPessoaJuridica.Visible = false;

            switch (tipoSelecionado)
            {
                case "PF":
                    textNome_PF.Text = func.Pessoa.getNomenclatura();
                    textCpf_PF.Text = func.Pessoa.getDocumento();
                    textEmail_PF.Text = func.Pessoa.Email;
                    textEndereco_PF.Text = func.Pessoa.Endereco;

                    //gbPessoaFiscia.Visible = true;
                    //gbPessoaJuridica.Visible = false;
                    break;

                case "PJ":
                    //textRazaoSocial_PJ.Text = func.Pessoa.Nomenclatura;
                    //textCnpj_PJ.Text = func.Pessoa.Documento;
                    //textEmail_PJ.Text = func.Pessoa.Email;
                    //textEndereco_PJ.Text = func.Pessoa.Endereco;

                    //gbPessoaFiscia.Visible = false;
                    //gbPessoaJuridica.Visible = true;
                    break;
            }
        }

        private void mostraFormPessoaFisica(object sender, EventArgs e)
        {
            //gbPessoaFiscia.Visible = true;
            //gbPessoaJuridica.Visible = false;
            tipoSelecionado = "PF";
        }

        private void mostraFormPessoaJuridica(object sender, EventArgs e)
        {
            //gbPessoaFiscia.Visible = false;
            //gbPessoaJuridica.Visible = true;
            tipoSelecionado = "PJ";
        }

        private void salvarFuncionario(Object sender, EventArgs e)
        {
            bool formularioValido = false;

            if (string.IsNullOrEmpty(textNome_PF.Text) || string.IsNullOrEmpty(textCpf_PF.Text) ||
                   string.IsNullOrEmpty(textEmail_PF.Text) || string.IsNullOrEmpty(textEndereco_PF.Text))
            {
                MessageBox.Show("Todos campos são obrigatórios");
                return;
            }

            formularioValido = true;

            //switch (tipoSelecionado)
            //{
            //    case "PF":
            //        if (string.IsNullOrEmpty(textNome_PF.Text) || string.IsNullOrEmpty(textCpf_PF.Text) ||
            //        string.IsNullOrEmpty(textEmail_PF.Text) || string.IsNullOrEmpty(textEndereco_PF.Text))
            //        {
            //            MessageBox.Show("Todos campos são obrigatórios");
            //            return;
            //        }

            //        formularioValido = true;
            //        break;

            //    case "PJ":
            //        if (string.IsNullOrEmpty(textRazaoSocial_PJ.Text) || string.IsNullOrEmpty(textCnpj_PJ.Text) ||
            //        string.IsNullOrEmpty(textEmail_PJ.Text) || string.IsNullOrEmpty(textEndereco_PJ.Text))
            //        {
            //            MessageBox.Show("Todos campos são obrigatórios");
            //            return;
            //        }

            //        formularioValido = true;
            //        break;
            //}

            if (!formularioValido) return;

            if (idSelecionado == null)
            {
                cadastrarFuncionario();
            }
            else
            {
                editarFuncionario();
            }
        }

        private void cadastrarFuncionario()
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = textNome_PF.Text;
            pf.CPF = textCpf_PF.Text;
            pf.Email = textEmail_PF.Text;
            pf.Endereco = textEndereco_PF.Text;

            Funcionario FuncionarioPF = new Funcionario();
            FuncionarioPF.Pessoa = pf;

            FuncionarioController.CadastrarFuncionario(FuncionarioPF);

            //switch (tipoSelecionado)
            //{
            //    case "PF":
            //        PessoaFisica pf = new PessoaFisica(textNome_PF.Text, textCpf_PF.Text, textEmail_PF.Text, textEndereco_PF.Text);
            //        Funcionario FuncionarioPF = new Funcionario(pf);

            //        FuncionarioController.CadastrarFuncionario(FuncionarioPF);
            //        break;

            //    case "PJ":
            //        PessoaJuridica pj = new PessoaJuridica(textRazaoSocial_PJ.Text, textCnpj_PJ.Text, textEmail_PJ.Text, textEndereco_PJ.Text);
            //        Funcionario FuncionarioPJ = new Funcionario(pj);

            //        FuncionarioController.CadastrarFuncionario(FuncionarioPJ);
            //        break;
            //}

            MessageBox.Show("Funcionario cadastrado com sucesso!");
            limparCampos();
        }

        private void editarFuncionario()
        {
            int funcId = Convert.ToInt32(idSelecionado);

            switch (tipoSelecionado)
            {
                case "PF":
                    FuncionarioController.EditarFuncionario(funcId, textNome_PF.Text, textCpf_PF.Text, textEmail_PF.Text, textEndereco_PF.Text);
                    break;

                case "PJ":
                    //FuncionarioController.EditarFuncionario(funcId, textRazaoSocial_PJ.Text, textCnpj_PJ.Text, textEmail_PJ.Text, textEndereco_PJ.Text);
                    break;
            }

            MessageBox.Show("Funcionario editado com sucesso!");
        }

        private void limparCampos()
        {
            //textRazaoSocial_PJ.Clear();
            //textCnpj_PJ.Clear();
            //textEmail_PJ.Clear();
            //textEndereco_PJ.Clear();

            textNome_PF.Clear();
            textCpf_PF.Clear();
            textEmail_PF.Clear();
            textEndereco_PF.Clear();
        }

        private void voltar(object sender, EventArgs e)
        {
            listaFuncionario listaFuncionario = new listaFuncionario();
            listaFuncionario.MdiParent = this.MdiParent;

            listaFuncionario.Show();
            listaFuncionario.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
