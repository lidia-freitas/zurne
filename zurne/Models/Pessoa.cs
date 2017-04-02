using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        public int? Id { get; set; }
        public string TipoPessoa;
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Pessoa() { }

        public Pessoa(int? id, string tipoPessoa, string email, string endereco) {
            this.Id = id;
            this.TipoPessoa = tipoPessoa;
            this.Email = email;
            this.Endereco = endereco;
        }
    }
}
