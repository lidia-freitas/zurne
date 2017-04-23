using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("PessoaJuridica")]
    public class PessoaJuridica : Pessoa, IPessoa
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public string Documento
        {
            get
            {
                return this.CNPJ;
            }

            set
            {
                this.CNPJ = value;
            }
        }

        public string Nomenclatura
        {
            get
            {
                return this.RazaoSocial;
            }

            set
            {
                this.RazaoSocial = value;
            }
        }
    }
}


