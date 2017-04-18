using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PessoaFisica> PessoaFisisca {get; set;}
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Bicicleta> Bicicleta { get; set; }
        public DbSet<Motocicleta> Motocicleta{ get; set; }
        public DbSet<Automovel> Automovel{ get; set; }

    }
}
