using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Motocicleta : Veiculo, ILicenciamento
    {
        public int Id { get; set; }
        public int Cilindradas { get; set; }
        public string Placa { get; set; }
        public string Renavam { get; set; }

        public Motocicleta(int cilindradas, string marca, string modelo, string cor, int ano)
            : base(marca, modelo, cor, ano)
        {            
            this.Cilindradas = cilindradas;
        }    

        

    }
}
