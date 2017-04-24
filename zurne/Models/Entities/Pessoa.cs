using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Pessoa")]
    public abstract class Pessoa
    {
        [key]
        public int PessoaId { get; set; }

        public string Email { get; set; }
        public string Endereco { get; set; }

        public abstract string Nomenclatura { get; set; }
        public abstract string Documento { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario Funcionario { get; set; }

    }
}
