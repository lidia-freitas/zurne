using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bicicleta : Veiculo
    {
        
        public int Marchas { get; set; }

        public Bicicleta(int marchas, string marca, string modelo, string cor, int ano) 
            : base(marca, modelo, cor, ano, 0)
        {
            this.Marchas = marchas;
        }

        public Bicicleta()
        {

        }

    }
}
