using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [key]
        public int PessoaId { get; set; }

        public string Email { get; set; }
        public string Endereco { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        public string getNomenclatura()
        {
            return (string)this.GetType().GetProperty("Nomenclatura").GetValue(this, null);
        }

        public void setNomenclatura(string nomenclatura)
        {
            GetType().GetProperty("Nomenclatura").SetValue(this, nomenclatura);
        }

        public string getDocumento()
        {
            return (string)this.GetType().GetProperty("Documento").GetValue(this, null);
        }

        public void setDocumento(string Documento)
        {
            GetType().GetProperty("Documento").SetValue(this, Documento);
        }
    }
}
