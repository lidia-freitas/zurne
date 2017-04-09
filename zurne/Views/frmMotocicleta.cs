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
    public partial class frmMotocicleta : Form
    {

        private string idSelecionado;

        public frmMotocicleta()
        {
            InitializeComponent();
            limparCampos();
        }

        public frmMotocicleta(string _idMotocicleta)
        {
            InitializeComponent();
            idSelecionado = _idMotocicleta;
            carregarMotocicleta();
        }

        private void carregarMotocicleta()
        {
            int motoId = Convert.ToInt32(idSelecionado);
            Motocicleta moto = MotocicletaController.BuscarMotocicleta(motoId);

            textMarca_Moto.Text = moto.Marca;
            textModelo_Moto.Text = moto.Modelo;
            textCor_Moto.Text = moto.Cor;
            textAno_Moto.Text = moto.Ano.ToString();
            textCilindradas_Moto.Text = moto.Cilindradas.ToString();
        }

        private void salvarMotocicleta(object sender, EventArgs e)
        {
            if (textMarca_Moto.Text == null || textModelo_Moto.Text == null || textCor_Moto.Text == null ||
                textAno_Moto.Text == null || textCilindradas_Moto.Text == null)
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return;
            }

            if(idSelecionado == null)
            {
                cadastrarMotocicleta();
            }
            else
            {
                editarMotocicleta();              
            }

        }

        private void cadastrarMotocicleta()
        {
            MotocicletaController.cadastrarMotocicleta(Convert.ToInt32(textCilindradas_Moto.Text), textMarca_Moto.Text, textModelo_Moto.Text,
                textCor_Moto.Text, Convert.ToInt32(textAno_Moto.Text));

            MessageBox.Show("Motocicleta cadastrada com sucesso!");
            limparCampos();
        }

        private void editarMotocicleta()
        {
            MotocicletaController.EditarMotocicleta(Convert.ToInt32(idSelecionado), Convert.ToInt32(textCilindradas_Moto.Text), 
                textMarca_Moto.Text, textModelo_Moto.Text, textCor_Moto.Text, Convert.ToInt32(textAno_Moto.Text));

            MessageBox.Show("Motocicleta cadastrada com sucesso!");
            limparCampos();
        }

        private void limparCampos()
        {
            textMarca_Moto.Clear();
            textModelo_Moto.Clear();
            textAno_Moto.Clear();
            textCor_Moto.Clear();
            textCilindradas_Moto.Clear();
        }

        private void voltar(object sender, EventArgs e)
        {
            listaMotocicleta listaMotocicleta = new listaMotocicleta();
            listaMotocicleta.MdiParent = this.MdiParent;

            listaMotocicleta.Show();
            listaMotocicleta.WindowState = FormWindowState.Maximized;
            this.Close();
        }

       
    }
}
