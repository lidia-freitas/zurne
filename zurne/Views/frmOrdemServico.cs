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
    public partial class frmOrdemServico : Form
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string TipoVeiculo { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string Obs { get; set; }

        public frmOrdemServico()
        {
                
        }

        public frmOrdemServico(string origem, string destino, string distancia, string valor, object veiculo)
        {
            InitializeComponent();

            System.Reflection.PropertyInfo pi = veiculo.GetType().GetProperty("Key");

            lbDestino.Text = "Destino: " + destino;
            lbOrigem.Text = "Origem: " + origem;
            lbTipoVeiculo.Text = "Veiculo: " + (string)(pi.GetValue(veiculo, null));
            lbDistancia.Text = "Distância: " + distancia;
            lbValor.Text = "Valor: R$" + valor;
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy");

            this.Origem = origem;
            this.Destino = destino;
            this.TipoVeiculo = (string)(pi.GetValue(veiculo, null));
            this.Valor = Convert.ToDouble(valor);
            this.Data = DateTime.Today;
            

            funcionariosAutoComplete();
            clientesAutoComplete();
            veiculosAutoComplete();

        }

        void funcionariosAutoComplete()
        {
            cbFuncionario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbFuncionario.AutoCompleteSource = AutoCompleteSource.ListItems;

            List<KeyValuePair<string, string>> listaFuncionarios = new List<KeyValuePair<string, string>>();
            List<Funcionario> selectFuncionarios = FuncionarioController.ListarFuncionarios();           

            foreach (Funcionario func in selectFuncionarios)
            {
                listaFuncionarios.Add(new KeyValuePair<string, string>(func.PessoaId.ToString(), func.Pessoa.Nomenclatura));            
            }

            cbFuncionario.DataSource = listaFuncionarios;
            cbFuncionario.DisplayMember = "Value";            
            cbFuncionario.ValueMember = "Key";
        }

        void clientesAutoComplete()
        {
            cbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            List<KeyValuePair<string, string>> listaClientes = new List<KeyValuePair<string, string>>();
            List<Cliente> selectClientes = ClienteController.ListarClientes();
            
            foreach (Cliente cli in selectClientes)
            {
                listaClientes.Add(new KeyValuePair<string, string>(cli.PessoaId.ToString(), cli.Pessoa.Nomenclatura));
            }

            cbCliente.DataSource = listaClientes;
            cbCliente.DisplayMember = "Value";
            cbCliente.ValueMember = "Key";
        }

        void veiculosAutoComplete()
        {
            cbVeiculo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbVeiculo.AutoCompleteSource = AutoCompleteSource.ListItems;

            List<KeyValuePair<string, string>> listaVeiculos = new List<KeyValuePair<string, string>>();
            


            switch (lbTipoVeiculo.Text)
            {
                case "Veiculo: Automovel":
                    List<Automovel> listaAutomoveis = AutomovelController.ListarAutomoveis();

                    foreach (var auto in listaAutomoveis)
                    {
                        listaVeiculos.Add(new KeyValuePair<string, string>(auto.Id.ToString(), auto.Modelo));
                    }
                    break;

                case "Veiculo: Motocicleta":
                    List<Motocicleta> listaMotocicletas = MotocicletaController.ListarMotocicletas();

                    foreach (var moto in listaMotocicletas)
                    {
                        listaVeiculos.Add(new KeyValuePair<string, string>(moto.Id.ToString(), moto.Modelo));
                    }
                    break;

                case "Veiculo: Bicicleta":
                    List<Bicicleta> listaBicicletas = BicicletaController.ListarBicicletas();

                    foreach (var bike in listaBicicletas)
                    {
                        listaVeiculos.Add(new KeyValuePair<string, string>(bike.Id.ToString(), bike.Modelo));
                    }
                    break;
            }

            cbVeiculo.DataSource = listaVeiculos;
            cbVeiculo.DisplayMember = "Value";
            cbVeiculo.ValueMember = "Key";
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmOrcamento frmOrcamento = new frmOrcamento();
            frmOrcamento.MdiParent = this.MdiParent;

            frmOrcamento.Show();
            frmOrcamento.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void criarOrdemServico(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbVeiculo.Text) || string.IsNullOrEmpty(cbCliente.Text) || string.IsNullOrEmpty(cbFuncionario.Text))
            {
                MessageBox.Show("Todos campos são obrigatórios");
                return;
            }

            this.Obs = txtObs.Text;

            System.Reflection.PropertyInfo cli = cbCliente.SelectedItem.GetType().GetProperty("Key");
            System.Reflection.PropertyInfo func = cbFuncionario.SelectedItem.GetType().GetProperty("Key");
            System.Reflection.PropertyInfo vei = cbVeiculo.SelectedItem.GetType().GetProperty("Key");

            var cliId = Convert.ToInt32(cli.GetValue(cbCliente.SelectedItem, null));
            var funcId = Convert.ToInt32(func.GetValue(cbFuncionario.SelectedItem, null));
            var veiId = Convert.ToInt32(vei.GetValue(cbVeiculo.SelectedItem, null));

            OrdemServicoController.CadastrarOrdemServico(this.Data, this.Origem, this.Destino,
                this.Valor, this.Obs, this.TipoVeiculo, cliId, funcId, veiId);

            MessageBox.Show("Ordem de serviço cadastrado com sucesso!");
            this.Close();

        }
    }
}
