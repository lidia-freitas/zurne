using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.DAL;
using System.Data.Entity;

namespace Controllers
{
    public class ClienteController
    {              
        public static Cliente BuscarCliente(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Cliente.Find(id);
            }
        }

        public static List<Cliente> ListarClientes()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Cliente.ToList();
            }
        }
  
        public static void CadastrarCliente(Cliente cli)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Cliente.Add(cli);
                ctx.SaveChanges();
            }
        }
   
        public static void EditarCliente(int id, string nomenclatura, string documento, string email, string endereco)
        {
            using (Contexto ctx = new Contexto())
            {
                Cliente cli = BuscarCliente(id);

                if (cli != null)
                {
                    cli.Pessoa.Nomenclatura = nomenclatura;
                    cli.Pessoa.Documento = documento;
                    cli.Pessoa.Endereco = endereco;
                    cli.Pessoa.Email = email;
                }

                ctx.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }            
        }

        public static void RemoverCliente(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Cliente cli = BuscarCliente(id);

                if (cli != null)
                {
                    ctx.Entry(cli).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
