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

        public PessoaJuridica(string rz, string cnpj, string contato, string email, string endereco)
               : base(email, endereco)

        {
            this.RazaoSocial = rz;
            this.CNPJ = cnpj;
            this.Contato = contato;
            
        }
    }
}