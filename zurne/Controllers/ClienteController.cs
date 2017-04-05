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

        private static List<PessoaFisica> listaPF = new List<PessoaFisica>();

        private static List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();

        private static List<Cliente> listaClientes = new List<Cliente>();


        public static int BuscarPF(int id)
        {
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.PessoaFisica.Id == id)
                {
                    return cliente.PessoaFisica.Id;
                }
            }            

            return 100000;
        }

        public static int BuscarPJ(int id)
        {
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.PessoaJuridica.Id == id)
                {
                    return cliente.PessoaJuridica.Id;
                }
            }

            return 1000000;
        }

        public static Cliente BuscarCliente(int id)
        {
            foreach (Cliente  cli in listaClientes)
            {
                if(cli.ID == id)
                {
                    return cli;
                }
            }

            return null;
        }


        public static List<PessoaFisica> ListarPF()
        {
            return listaPF;
        }

        public static List<PessoaJuridica> ListarPJ()
        {
            return listaPJ;
        }

        public static List<Cliente> ListarClientes()
        {
            return listaClientes;
        }

  
        public static void CadastrarCliente(Cliente cli)
        {            
            cli.ID = listaClientes.Count() + 1;

            if (cli.PessoaFisica != null){
                cli.PessoaFisica.Id = listaPF.Count() + 1;
                listaPF.Add(cli.PessoaFisica);
            }

            if(cli.PessoaJuridica != null)
            {
                cli.PessoaJuridica.Id = listaPJ.Count() + 1;
                listaPJ.Add(cli.PessoaJuridica);
            }
            
            listaClientes.Add(cli);
        }


        //public static void EditarPf(int? id, string nome, string cpf, string email, string end)
        //{
        //    PessoaFisica pf = BuscarPF(id);

        //    if (pf != null)
        //    {
        //        pf.Nome = nome;
        //        pf.CPF = cpf;
        //        pf.Email = email;
        //        pf.Endereco = end;
        //    }
        //}
        
        //public static void EditarPj(int? id, string razaoSocial, string cnpj, string contato, string email, string endereco)
        //{
        //    PessoaJuridica pj = BuscarPJ(id);

        //    if (pj != null)
        //    {
        //        pj.RazaoSocial = razaoSocial;
        //        pj.CNPJ = cnpj;
        //        pj.Email = email;
        //        pj.Endereco = endereco;
        //        pj.Contato = contato;
        //    }
        //}

        public static void EditarCliente(Cliente cli)
        {
            
            
        }


        //public static void RemoverPF(int? id)
        //{
        //    foreach (PessoaFisica pf in listaPF)
        //    {
        //        if (pf.Id == id)
        //        {
        //            listaPF.Remove(pf);
        //        }
        //    }
        //}
        
        //public static void RemoverPJ(int? id)
        //{
        //    foreach (PessoaJuridica pj in listaPJ)
        //    {
        //        if (pj.Id == id)
        //        {
        //            listaPJ.Remove(pj);
        //        }
        //    }
        //}

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
