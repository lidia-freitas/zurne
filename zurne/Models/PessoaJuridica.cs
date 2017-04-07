using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PessoaJuridica : Pessoa, IPessoa
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public string Documento
        {
            get
            {
                return CNPJ;
            }
           
        }

        public string Nomenclatura
        {
            get
            {
                return RazaoSocial;
            }
            
        }

        public PessoaJuridica(string rasaoSocial, string cnpj, string email, string endereco)
            : base (email, endereco)
        {
            this.RazaoSocial = rasaoSocial;
            this.CNPJ = cnpj;            
        }
    }
}


