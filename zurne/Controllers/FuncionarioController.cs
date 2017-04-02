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
        private static List<PessoaFisica> listaFuncionarios = new List<PessoaFisica>();

        private PessoaFisica Buscar(int id) {
            foreach (PessoaFisica func in listaFuncionarios)
            {
                if (func.Id == id)
                {
                    return func;
                }
            }

            return null;
        }

        public List<PessoaFisica> Listar()
        {
            return listaFuncionarios;
        }

        public void Cadastrar(string nome, string tipo, string cpf, string email, string endereco)
        {
            PessoaFisica func = new PessoaFisica(null, nome, cpf, email, endereco);
            listaFuncionarios.Add(func);
        }

        public void Remover(int id)
        {
            foreach (PessoaFisica func in listaFuncionarios)
            {
                if(func.Id == id)
                {
                    listaFuncionarios.Remove(func);
                }
            }
        }

        public void Editar(int id, string nome, string cpf, string email, string end)
        {
            PessoaFisica func = Buscar(id);

            if(func != null)
            {
                func.Nome = nome;
                func.CPF = cpf;
                func.Email = email;
                func.Endereco = end;
            }
        }

    }


}
