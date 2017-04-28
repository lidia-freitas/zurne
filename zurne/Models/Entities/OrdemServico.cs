using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("OrdensServico")]
    public class OrdemServico
    {
        [key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }

        public double Valor { get; set; }
        public string Obs { get; set; }

        public virtual Funcionario Funcionario { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Veiculo Veiculo { get; set; }

        public OrdemServico()
        {
        }
    }
}
