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
        private int idSelecionado { get; set; }     

        public listaCliente()
        {
            InitializeComponent();
        }        

        private void listaClientesLoad(object sender, EventArgs e)
        {
            dataGridClientesPF.DataSource = null;
            dataGridClientesPF.DataSource = ClienteController.ListarPF();            
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
            MessageBox.Show(idSelecionado.ToString());
            frmCliente frmCliente = new frmCliente(idSelecionado, "F");

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
            idSelecionado = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value);
        }
    }        
}
