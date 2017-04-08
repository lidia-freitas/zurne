using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public Veiculo Veiculo { get; set; }
        public DateTime Data { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public double Valor { get; set; }
        public string Obs { get; set; }

        public OrdemServico(int Id, string latitude, string longitude, DateTime data, string obs) { }
    }
}
