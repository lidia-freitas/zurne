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
        public new string Email { get; set; }
        public new string Endereco { get; set; }


        public PessoaFisica(){}

        public PessoaFisica(string nome, string cpf, string email, string endereco)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
            this.Email = endereco;
        }
    }
}
