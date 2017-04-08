using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public readonly IPessoa Pessoa;

        public Cliente(IPessoa p) {
            Pessoa = p;
        }
    }
}
