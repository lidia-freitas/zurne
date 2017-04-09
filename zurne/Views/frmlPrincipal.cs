using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }       

        private void listarClientes(object sender, EventArgs e)
        {
            listaCliente listaCliente = new listaCliente();
            listaCliente.MdiParent = this;
            listaCliente.Show();
            listaCliente.WindowState = FormWindowState.Maximized;
        }

        private void listarFuncionarios(object sender, EventArgs e)
        {
            listaFuncionario listaFuncionario = new listaFuncionario();
            listaFuncionario.MdiParent = this;
            listaFuncionario.Show();
            listaFuncionario.WindowState = FormWindowState.Maximized;
        }

        private void listarAutomoveis(object sender, EventArgs e)
        {
            listaAutomovel listaAutomovel = new listaAutomovel();
            listaAutomovel.MdiParent = this;
            listaAutomovel.Show();
            listaAutomovel.WindowState = FormWindowState.Maximized;
        }

        private void listarMotocicletas(object sender, EventArgs e)
        {
            listaMotocicleta listaMotocicleta = new listaMotocicleta();
            listaMotocicleta.MdiParent = this;
            listaMotocicleta.Show();
            listaMotocicleta.WindowState = FormWindowState.Maximized;
        }

        private void listarBicicletas(object sender, EventArgs e)
        {
            listaBicicleta listaBicicleta = new listaBicicleta();
            listaBicicleta.MdiParent = this;
            listaBicicleta.Show();
            listaBicicleta.WindowState = FormWindowState.Maximized;
        }

    }
}
