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


        public static PessoaFisica BuscarPF(int? id)
        {
            foreach (PessoaFisica pf in listaPF)
            {
                if (pf.Id == id)
                {
                    return pf;
                }
            }

            return null;
        }

        public static PessoaJuridica BuscarPJ(int? id)
        {
            foreach (PessoaJuridica pj in listaPJ)
            {
                if (pj.Id == id)
                {
                    return pj;
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

        public static void CadastrarPf(string nome, string cpf, string email, string endereco)
        {
            PessoaFisica pf = new PessoaFisica (null, nome, cpf, email, endereco);
            pf.Id = listaPF.Count() + 1;
            listaPF.Add(pf);
        }
        
        public static void CadastrarPj(string razaoSocial, string cnpj, string contato, string email, string endereco)
        {
            PessoaJuridica pj = new PessoaJuridica(null, razaoSocial, cnpj, contato, email, endereco);
            pj.Id = listaPJ.Count() + 1;
            listaPJ.Add(pj);
        }

        public static void RemoverPF(int id)
        {
            foreach (PessoaFisica pf in listaPF)
            {
                if (pf.Id == id)
                {
                    listaPF.Remove(pf);
                }
            }
        }

        public static void RemoverPJ(int id)
        {
            foreach (PessoaJuridica pj in listaPJ)
            {
                if (pj.Id == id)
                {
                    listaPJ.Remove(pj);
                }
            }
        }

        public static void EditarPf(int id, string nome, string tipo, string cpf, string email, string end)
        {
            PessoaFisica pf = BuscarPF(id);

            if (pf != null)
            {
                pf.Nome = nome;
                pf.CPF = cpf;
                pf.Email = email;
                pf.Endereco = end;
            }
        }
        
        public static void EditarPj(int id, string razaoSocial, string tipo, string cnpj, string contato, string email, string endereco)
        {
            PessoaJuridica pj = BuscarPJ(id);

            if (pj != null)
            {
                pj.RazaoSocial = razaoSocial;
                pj.CNPJ = cnpj;
                pj.Email = email;
                pj.Endereco = endereco;
                pj.Contato = contato;
            }
        }

        
    }
}
