using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [key, ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        [Required]
        public virtual Pessoa Pessoa { get; set; }
    }
}
