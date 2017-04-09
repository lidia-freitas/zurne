using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bicicleta : Veiculo
    {
        public int Id { get; set; }
        public int Marchas { get; set; }

        public Bicicleta(int marchas, string marca, string modelo, string cor, int ano) : base(marca, modelo, cor, ano)
        {            
            this.Marchas = marchas;
        }

    }
}
