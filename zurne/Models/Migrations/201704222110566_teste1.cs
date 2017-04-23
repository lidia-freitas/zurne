namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PessoaFisica", "Documento", c => c.String());
            AddColumn("dbo.PessoaFisica", "Nomenclatura", c => c.String());
            AddColumn("dbo.PessoaJuridica", "Documento", c => c.String());
            AddColumn("dbo.PessoaJuridica", "Nomenclatura", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PessoaJuridica", "Nomenclatura");
            DropColumn("dbo.PessoaJuridica", "Documento");
            DropColumn("dbo.PessoaFisica", "Nomenclatura");
            DropColumn("dbo.PessoaFisica", "Documento");
        }
    }
}
