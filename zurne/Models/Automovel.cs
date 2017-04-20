using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Automovel : Veiculo
    {
        public double Potencia { get; set; }
        public string Placa { get; set; }
        public string Renavam { get; set; }

        public Automovel(double potencia, string marca, string modelo, string cor, int ano)
            : base(marca, modelo, cor, ano)
        {
            this.Potencia = potencia;
        }

        public Automovel()
        {

        }

    }
}
