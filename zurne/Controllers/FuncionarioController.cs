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

        public static Funcionario BuscarFuncionario(int id)
        {
            foreach (Funcionario func in listaFuncionarios)
            {
                if (func.Id == id)
                {
                    return func;
                }
            }

            return null;
        }

        public static List<Funcionario> ListarFuncionarios()
        {
            return listaFuncionarios;
        }

        public static void CadastrarFuncionario(Funcionario func)
        {
            func.Id = listaFuncionarios.Count();
            listaFuncionarios.Add(func);
        }

        public static void EditarFuncionario(int id, string nomenclatura, string documento, string email, string endereco)
        {
            Funcionario func = BuscarFuncionario(id);

            func.Pessoa.Nomenclatura = nomenclatura;
            func.Pessoa.Documento = documento;
            func.Pessoa.Endereco = endereco;
            func.Pessoa.Email = email;
        }

        public static void RemoverFuncionario(int id)
        {
            Funcionario func = BuscarFuncionario(id);
            listaFuncionarios.Remove(func);
        }
    }
}
