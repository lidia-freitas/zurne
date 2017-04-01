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

        public Cliente Buscar(int? id)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ID == id)
                {
                    return cli;
                }
            }

            return null;
        }

        public List<Cliente> Listar()
        {
            return listaClientes;
        }

        public void CadastrarPf(string nome, string cpf, string email, string endereco)
        {
            PessoaFisica pf = new PessoaFisica (nome, cpf, email, endereco);

            Cliente cli = new Cliente(pf);

            listaClientes.Add(cli);
        }
        
        public void CadastrarPj(string rz, string cnpj, string contato, string email, string endereco)
        {
            PessoaJuridica pj = new PessoaJuridica (rz, cnpj, contato, email, endereco);

            Cliente cli = new Cliente(pj);

            listaClientes.Add(cli);
        }

        public void Remover(int id)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ID == id)
                {
                    listaClientes.Remove(cli);
                }
            }
        }

        public void EditarPf(int id, string nome, string cpf, string email, string end)
        {
            Cliente cli = Buscar(id);

            if (cli != null)
            {
                cli.PessoaFisica.Nome = nome;
                cli.PessoaFisica.CPF = cpf;
                cli.PessoaFisica.Email = email;
                cli.PessoaFisica.Endereco = end;
            }
        }
        
        public void EditarPj(int id, string rz, string cnpj, string contato, string email, string endereco)
        {
            Cliente cli = Buscar(id);

            if (cli != null)
            {
                cli.PessoaJuridica.RazaoSocial = rz;
                cli.PessoaJuridica.CNPJ = cnpj;
                cli.PessoaJuridica.Email = email;
                cli.PessoaJuridica.Endereco = endereco;
                cli.PessoaJuridica.Contato = contato;
            }
        }

    }
}
