using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.DAL;

namespace Controllers
{
    public class FuncionarioController
    {
        public static Funcionario BuscarFuncionario(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Funcionario.Find(id);
            }
        }

        public static List<Funcionario> ListarFuncionarios()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Funcionario.ToList();
            }
        }

        public static void CadastrarFuncionario(Funcionario func)
        {
            using (Contexto ctx = new Contexto())
            {
                ctx.Funcionario.Add(func);
                ctx.SaveChanges();
            }
        }

        public static void EditarFuncionario(int id, string nomenclatura, string documento, string email, string endereco)
        {
            using (Contexto ctx = new Contexto())
            {
                Funcionario func = BuscarFuncionario(id);

                if (func != null)
                {
                    func.Pessoa.Nomenclatura = nomenclatura;
                    func.Pessoa.Documento = documento;
                    func.Pessoa.Endereco = endereco;
                    func.Pessoa.Email = email;
                }

                ctx.Entry(func).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public static void RemoverFuncionario(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Funcionario func = BuscarFuncionario(id);

                if (func != null)
                {
                    ctx.Entry(func).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
