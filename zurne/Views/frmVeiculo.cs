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
    public partial class frmVeiculo : Form
    {
        private string idSelecionado;
        private string tipoSelecionado;

        public frmVeiculo()
        {
            InitializeComponent();
            limparCampos();
        }

        public frmVeiculo(string _idVeiculo, string _tipoVeiculo)
        {
            InitializeComponent();

            idSelecionado = _idVeiculo;
            tipoSelecionado = _tipoVeiculo;

            carregarVeiculo();
        }

        private void carregarVeiculo()
        {

        }

        private void mostraFormBicicleta(object sender, EventArgs e)
        {
            gbBicicleta.Visible = true;
            gbMotocicleta.Visible = false;
            gbAutomovel.Visible = false;
            tipoSelecionado = "Bic";
        }

        private void mostraFormMotocicleta(object sender, EventArgs e)
        {
            gbBicicleta.Visible = false;
            gbMotocicleta.Visible = true;
            gbAutomovel.Visible = false;
            tipoSelecionado = "Mot";
        }

        private void mostraFormAutomovel(object sender, EventArgs e)
        {
            gbBicicleta.Visible = false;
            gbMotocicleta.Visible = false;
            gbAutomovel.Visible = true;
            tipoSelecionado = "Auto";
        }

        private void salvarVeiculo(object sender, EventArgs e)
        {

        }

        private void cadastrarVeiculo() { }

        private void editarVeiculo() { }

        private void limparCampos()
        {
            textMarca_Bic.Clear();
            textModelo_Bic.Clear();
            textAno_Bic.Clear();
            textCor_Bic.Clear();
            textMarchas_Bic.Clear();

            textMarca_Mot.Clear();
            textModelo_Mot.Clear();
            textAno_Mot.Clear();
            textCor_Mot.Clear();
            textCilindradas_Mot.Clear();

            textMarca_Auto.Clear();
            textModelo_Auto.Clear();
            textAno_Auto.Clear();
            textCor_Auto.Clear();
            textPotencia_Auto.Clear();
        }

        private void voltar(object sender, EventArgs e)
        {
            listaVeiculo listaVeiculo = new listaVeiculo();
            listaVeiculo.MdiParent = this.MdiParent;

            listaVeiculo.Show();
            listaVeiculo.WindowState = FormWindowState.Maximized;
            this.Close();
        }
        
    }
}
