using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PessoaJuridica : Pessoa
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Contato { get; set; }
        public new string Email { get; set; }
        public new string Endereco { get; set; }

        public PessoaJuridica(){}

        public PessoaJuridica(string rasaoSocial, string cnpj, string contato, string email, string endereco)
        {
            this.RazaoSocial = rasaoSocial;
            this.CNPJ = cnpj;
            this.Contato = contato;
            this.Email = email;
            this.Endereco = endereco;

        }
    }
}
