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
    public class FuncionarioController
    {
        public static Funcionario BuscarFuncionario(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Funcionario.Include(f => f.Pessoa).FirstOrDefault(f => f.PessoaId == id);
            }
        }

        public static Funcionario BuscarFuncionario(int id, Contexto ctx)
        {
            return ctx.Funcionario.Include(f => f.Pessoa).FirstOrDefault(f => f.PessoaId == id);
        }

        public static List<Funcionario> ListarFuncionarios()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Funcionario.Include(c => c.Pessoa).ToList();
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
                Funcionario func = BuscarFuncionario(id, ctx);

                if (func != null)
                {
                    func.Pessoa.Nomenclatura = nomenclatura;
                    func.Pessoa.Documento = documento;
                    func.Pessoa.Endereco = endereco;
                    func.Pessoa.Email = email;
                }

                ctx.Entry(func).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public static void RemoverFuncionario(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Funcionario func = BuscarFuncionario(id, ctx);

                if (func != null)
                {
                    ctx.Entry(func).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
