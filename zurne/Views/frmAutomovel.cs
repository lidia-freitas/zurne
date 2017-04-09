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
    public partial class frmAutomovel : Form
    {
        private string idSelecionado;

        public frmAutomovel()
        {
            InitializeComponent();
            limparCampos();
        }

        public frmAutomovel(string _idAutomovel)
        {
            InitializeComponent();
            idSelecionado = _idAutomovel;
            carregarAutomovel();
        }

        private void carregarAutomovel()
        {
            int autoId = Convert.ToInt32(idSelecionado);
            Automovel auto = AutomovelController.BuscarAutomovel(autoId);
                
            textMarca_Auto.Text = auto.Marca;
            textModelo_Auto.Text = auto.Modelo;
            textCor_Auto.Text = auto.Cor;
            textAno_Auto.Text = auto.Ano.ToString();
            textPotencia_Auto.Text = auto.Potencia.ToString();
        }

        private void salvarAutomovel(object sender, EventArgs e)
        {
            if(textMarca_Auto.Text == null || textModelo_Auto.Text == null || textCor_Auto.Text == null || 
                textAno_Auto.Text == null || textPotencia_Auto.Text == null)
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return;
            }

            if(idSelecionado == null)
            {
                cadastrarAutomovel();
            }else
            {
                editarAutomovel();
            }
        }

        private void cadastrarAutomovel()
        {
            AutomovelController.CadastrarAutomovel(Convert.ToDouble(textPotencia_Auto.Text), textMarca_Auto.Text, textModelo_Auto.Text, 
                textCor_Auto.Text, Convert.ToInt32(textAno_Auto.Text));

            MessageBox.Show("Automóvel cadastrado com sucesso!");
            limparCampos();
        }

        private void editarAutomovel()
        {
            AutomovelController.EditarAuomovel(Convert.ToInt32(idSelecionado), Convert.ToDouble(textPotencia_Auto.Text),
                textMarca_Auto.Text, textModelo_Auto.Text, textCor_Auto.Text, Convert.ToInt32(textAno_Auto.Text));

            MessageBox.Show("Automóvel cadastrado com sucesso!");
            limparCampos();
        }

        private void limparCampos()
        {
            textMarca_Auto.Clear();
            textModelo_Auto.Clear();
            textAno_Auto.Clear();
            textCor_Auto.Clear();
            textPotencia_Auto.Clear();

        }

        private void voltar(object sender, EventArgs e)
        {
            listaAutomovel listaAutomovel = new listaAutomovel();
            listaAutomovel.MdiParent = this.MdiParent;

            listaAutomovel.Show();
            listaAutomovel.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        
    }
}
