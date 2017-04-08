using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Veiculo
    {

        public int ID;
        public string Tipo { get; set; }
        public string MarcaModelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Renavam { get; set; }

        public Veiculo (string tipo, string marcamodelo, int ano, string placa, string renavam)
        {
            this.Tipo = tipo;
            this.MarcaModelo = marcamodelo;
            this.Ano = ano;
            this.Placa = placa;
            this.Renavam = renavam;
        }

    }
}
