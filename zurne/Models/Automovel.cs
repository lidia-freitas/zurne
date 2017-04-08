using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Automovel : Veiculo, ILicenciamento
    {
        public double Potencia { get; set; }

        public Automovel(double Potencia, string marca, string modelo, string cor, int ano)
           : base(marca, modelo, cor, ano)
        {
        }

        public string Placa
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Renavam
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

       

    }
}
