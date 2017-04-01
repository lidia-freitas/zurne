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
        public DataGridView clientesDataGrid { get; set; }

        public listaCliente()
        {
            InitializeComponent();
        }        

        private void listaClientesLoad(object sender, EventArgs e)
        {
            dataGridClientes.DataSource = null;
            dataGridClientes.DataSource = ClienteController.Listar();
        }

        private void cadastrarCliente(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente(null, null);            
            frmCliente.MdiParent = this.MdiParent;
            
            frmCliente.Show();
            frmCliente.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void editarCliente(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente(0, 1);

            frmCliente.MdiParent = this.MdiParent;
            
            frmCliente.Show();
            frmCliente.WindowState = FormWindowState.Maximized;
            this.Close();
        }        
    }        
}
