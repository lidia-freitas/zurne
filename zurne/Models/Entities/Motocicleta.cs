using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Motocicletas")]
    public class Motocicleta : Veiculo
    {        
        public int Cilindradas { get; set; }
        public string Placa { get; set; }
        public string Renavam { get; set; }

        public Motocicleta(int cilindradas, string marca, string modelo, string cor, int ano, int autonomia)
            : base(marca, modelo, cor, ano, autonomia)
        {
            this.Cilindradas = cilindradas;
        }

        public Motocicleta()
        {

        }
    }
}
