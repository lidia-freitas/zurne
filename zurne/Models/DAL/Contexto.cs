using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasKey(t => t.PessoaId);
            modelBuilder.Entity<Funcionario>().HasKey(t => t.PessoaId);

            modelBuilder.Entity<Pessoa>().HasRequired(t => t.Cliente).WithRequiredPrincipal(t => t.Pessoa);
            modelBuilder.Entity<Pessoa>().HasRequired(t => t.Funcionario).WithRequiredPrincipal(t => t.Pessoa);
        }


        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaFisica> PessoaFisisca {get; set;}
        public virtual DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<Veiculo> Veiculo { get; set; }
        public virtual DbSet<Bicicleta> Bicicleta { get; set; }
        public virtual DbSet<Automovel> Automovel { get; set; }
        public virtual DbSet<Motocicleta> Motocicleta { get; set; }
        public virtual DbSet<OrdemServico> OrdemServico { get; set; }
    }

}

