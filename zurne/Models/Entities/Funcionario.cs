using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [key, ForeignKey("Pessoa")]        
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
