using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("PessoaFisica")]
    public class PessoaFisica : Pessoa, IPessoa
    {     
        public string Nome { get; set; }
        public string CPF { get; set; }             

        public string Documento
        {
            get
            {
                return this.CPF;
            }

            set
            {
                this.CPF = value;
            }
        }

        public string Nomenclatura
        {
            get
            {
                return this.Nome;
            }

            set
            {
                this.Nome = value;
            }
        }
    }
}
