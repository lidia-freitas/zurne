using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Pessoa
    {
        public string Email { get; set; }
        protected string Endereco { get; set; }

        public Pessoa(string email, string endereco)
        {
            this.Email = email;
            this.Endereco = endereco;
        }
    }
}
