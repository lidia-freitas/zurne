using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("PessoasFisicas")]
    public class PessoaFisica : Pessoa, IPessoa
    {     
        public string Nome { get; set; }
        public string CPF { get; set; }             

        public override  string Documento
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

        public override string Nomenclatura
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

