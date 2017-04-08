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
                if(cli.Id == id)
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
            cli.Id = listaClientes.Count();
            listaClientes.Add(cli);
        }
   
        public static void EditarCliente(int id, string nomenclatura, string documento, string email, string endereco)
        {
            Cliente cli = BuscarCliente(id);

            cli.Pessoa.Nomenclatura = nomenclatura;
            cli.Pessoa.Documento = documento;
            cli.Pessoa.Endereco = endereco;
            cli.Pessoa.Email = email; 
        }

        public static void RemoverCliente(int id)
        {
            Cliente cli = BuscarCliente(id);

            listaClientes.Remove(cli);
        }
    }
}
