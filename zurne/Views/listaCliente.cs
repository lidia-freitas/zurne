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
    public partial class listaCliente : Form
    {

        private int idSelecionado { get; set; }
        public string tipoPessoaSelecionada { get; set; }


        public listaCliente()
        {
            InitializeComponent();
        }        

        private void listaClientesLoad(object sender, EventArgs e)
        {
            dataGridClientesPF.DataSource = ClienteController.ListarPF();
            dataGridClientesPJ.DataSource = ClienteController.ListarPJ();
            


            //MessageBox.Show(dataGridClientesPF.FirstDisplayedCell.ColumnIndex.ToString());
            //MessageBox.Show(dataGridClientesPJ.FirstDisplayedCell.ColumnIndex.ToString());

            //dataGridClientesPF.FirstDisplayedCell = dataGridClientesPF.CurrentCell;
            // dataGridClientesPJ.FirstDisplayedCell = dataGridClientesPJ.CurrentCell;
        }

        private void cadastrarCliente(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();            
            frmCliente.MdiParent = this.MdiParent;
            
            frmCliente.Show();
            frmCliente.WindowState = FormWindowState.Maximized;
            this.Close();
        }                          

        private void editarCliente(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente(idSelecionado, tipoPessoaSelecionada);

            frmCliente.MdiParent = this.MdiParent;

            frmCliente.Show();
            frmCliente.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void removerCliente(object sender, EventArgs e)
        {

        }
      
        private void selecionarClientePJ(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int idPF = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value);
            //idSelecionado = ClienteController.BuscarPJ(idPF);            

            tipoPessoaSelecionada = "PJ";
            idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value);
        }

        private void selecionarClientePF(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int idPJ = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value);
            //idSelecionado = ClienteController.BuscarPJ(idPJ);
          
            idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value);
            tipoPessoaSelecionada = "PF";
        }        
    }        
}
