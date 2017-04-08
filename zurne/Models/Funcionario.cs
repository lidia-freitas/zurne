using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public readonly IPessoa Pessoa;
        
        public Funcionario(IPessoa p)
        {
            this.Pessoa = p;
        }
    }
}
