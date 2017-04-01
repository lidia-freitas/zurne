using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class FuncionarioController
    {
        private static List<Funcionario> listaFuncionarios = new List<Funcionario>();

        private Funcionario Buscar(int id) {
            foreach (Funcionario func in listaFuncionarios)
            {
                if (func.ID == id)
                {
                    return func;
                }
            }

            return null;
        }

        public List<Funcionario> Listar()
        {
            return listaFuncionarios;
        }

        public void Cadastrar(string nome, string cpf, string email, string end)
        {
            Funcionario func = new Funcionario(nome, cpf, email, end);

            listaFuncionarios.Add(func);
        }

        public void Remover(int id)
        {
            foreach (Funcionario func in listaFuncionarios)
            {
                if(func.ID == id)
                {
                    listaFuncionarios.Remove(func);
                }
            }
        }

        public void Editar(int id, string nome, string cpf, string email, string end)
        {
            Funcionario func = Buscar(id);

            if(func != null)
            {
                func.PessoaFisica.Nome = nome;
                func.PessoaFisica.CPF = cpf;
                func.PessoaFisica.Email = email;
                func.PessoaFisica.Endereco = end;
            }
        }

    }


}
