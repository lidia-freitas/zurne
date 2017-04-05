using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PessoaJuridica
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(int id, string rasaoSocial, string cnpj, string contato, string email, string endereco)
        {
            this.Id = Id;
            this.RazaoSocial = rasaoSocial;
            this.CNPJ = cnpj;
            this.Contato = contato;
            this.Email = email;
            this.Endereco = endereco;
        }
    }
}
