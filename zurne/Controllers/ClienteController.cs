using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class ClienteController
    {

        private static List<Cliente> listaClientes = new List<Cliente>();
              
        public static Cliente BuscarCliente(int id)
        {
            foreach (Cliente cli in listaClientes)
            {
                if(cli.ID == id)
                {
                    return cli;
                }
            }

            return null;
        }

        public static List<Cliente> ListarClientes()
        {
            return listaClientes;
        }
  
        public static void CadastrarCliente(Cliente cli)
        {            
            cli.ID = listaClientes.Count() + 1;
            listaClientes.Add(cli);
        }
   
        public static void EditarCliente(Cliente cli)
        {
            Cliente c = BuscarCliente(cli.ID);

            c.Pessoa.Nomenclatura = cli.Pessoa.Nomenclatura;
            c.Pessoa.Documento = cli.Pessoa.Documento;
            
        }

        public static void removerCliente(int id)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ID == id)
                {
                    listaClientes.Remove(cli);
                }
            }
        }
    }
}
