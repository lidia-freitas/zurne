using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PessoaFisica : Pessoa
    {

        public string Nome { get; set; }
        public string CPF { get; set; }


        public PessoaFisica(string nome, string cpf, string email, string endereco)
            : base(email, endereco)
        {
            this.Nome = nome;
            this.CPF = cpf;
        }
    }
}
