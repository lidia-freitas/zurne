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

        private void listarClientes(object sender, EventArgs e)
        {
            dataGridClientes.DataSource = ClienteController.ListarClientes();
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
            frmCliente frmCliente = new frmCliente(idSelecionado);
            frmCliente.MdiParent = this.MdiParent;

            frmCliente.Show();
            frmCliente.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void removerCliente(object sender, EventArgs e)
        {

        }     


        private void selecionarCliente(object sender, DataGridViewCellMouseEventArgs e)
        {               
            idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value);
        }      

        
    }        
}
