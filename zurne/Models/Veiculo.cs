using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public abstract class Veiculo
    {
        public int Id;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }



        public Veiculo (string marca, string modelo, string cor, int ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Ano = ano;
        }

    }
}
