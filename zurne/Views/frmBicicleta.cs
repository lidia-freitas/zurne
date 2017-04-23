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
    public partial class frmBicicleta : Form
    {
        private string idSelecionado;

        public frmBicicleta()
        {
            InitializeComponent();
            limparCampos();
        }

        public frmBicicleta(string _idBicicleta)
        {
            InitializeComponent();
            idSelecionado = _idBicicleta; 
            carregarBicicleta();
        }

        private void carregarBicicleta()
        {
            int bikeId = Convert.ToInt32(idSelecionado);
            Bicicleta bike = BicicletaController.BuscarBicicleta(bikeId);

            textMarca_Bike.Text = bike.Marca;
            textModelo_Bike.Text = bike.Modelo;
            textCor_Bike.Text = bike.Cor;
            textAno_Bike.Text = bike.Ano.ToString();
            textMarchas_Bike.Text = bike.Marchas.ToString();            
        }

        private void salvarBicicleta(object sender, EventArgs e)
        {
            if (textMarca_Bike.Text == null || textModelo_Bike.Text == null || textCor_Bike.Text == null || 
                textAno_Bike.Text == null || textMarchas_Bike == null)
            {
                MessageBox.Show("Todos os campos são obrigatórios");
                return;
            }

            if(idSelecionado == null)
            {
                cadastrarBicicleta();
            }
            else
            {
                editarBicicleta();
            }
        }

        private void cadastrarBicicleta()
        {
            BicicletaController.CadastrarBicicleta(Convert.ToInt32(textMarchas_Bike.Text), textMarca_Bike.Text, textModelo_Bike.Text,
                textCor_Bike.Text, Convert.ToInt32(textAno_Bike.Text));

            MessageBox.Show("Bicicleta cadastrada com sucesso!");
            limparCampos();
        }

        private void editarBicicleta()
        {
            BicicletaController.EditarBicicleta(Convert.ToInt32(idSelecionado), Convert.ToInt32(textMarchas_Bike.Text), textMarca_Bike.Text,
                textModelo_Bike.Text, textCor_Bike.Text, Convert.ToInt32(textAno_Bike.Text));

            MessageBox.Show("Bicicleta editada com sucesso!");
        }

        private void limparCampos()
        {
            textMarca_Bike.Clear();
            textModelo_Bike.Clear();
            textAno_Bike.Clear();
            textCor_Bike.Clear();
            textMarchas_Bike.Clear();
        }

        private void voltar(object sender, EventArgs e)
        {
            listaBicicleta listaBicicleta = new listaBicicleta();
            listaBicicleta.MdiParent = this.MdiParent;

            listaBicicleta.Show();
            listaBicicleta.WindowState = FormWindowState.Maximized;
            this.Close();
        }        
    }
}
