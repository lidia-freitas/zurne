namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Endereco = c.String(),
                        Nome = c.String(),
                        CPF = c.String(),
                        Documento = c.String(),
                        Nomenclatura = c.String(),
                        RazaoSocial = c.String(),
                        CNPJ = c.String(),
                        Documento1 = c.String(),
                        Nomenclatura1 = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
            DropTable("dbo.Clientes");
        }
    }
}
