using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public int ID;
        public PessoaFisica PessoaFisica;
        public PessoaJuridica PessoaJuridica;

        public Cliente(PessoaFisica pf)
        {
            this.PessoaFisica = pf;
        }

        public Cliente(PessoaJuridica pj)
        {
            this.PessoaJuridica = pj;
        }
    }
}
