using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Veiculos")]
    public abstract class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public int Autonomia { get; set; }

        public Veiculo(string marca, string modelo, string cor, int ano, int autonomia)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Ano = ano;
            this.Autonomia = autonomia;
        }

        public Veiculo()
        {

        }

    }
}
