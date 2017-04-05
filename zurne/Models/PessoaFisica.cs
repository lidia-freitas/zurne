using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(int id, string nome, string cpf, string email, string endereco)
            
        {
            this.Id = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
            this.Endereco = endereco;
        }
    }
}
