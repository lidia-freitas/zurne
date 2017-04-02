using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        public PessoaFisica PessoaFisica;

        public Funcionario(PessoaFisica pf)
        {
            this.PessoaFisica = pf;
        }
    }
}
