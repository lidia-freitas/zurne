namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veiculos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Cor = c.String(),
                        Ano = c.Int(nullable: false),
                        Autonomia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.PessoaId);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Automoveis",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Potencia = c.Double(nullable: false),
                        Placa = c.String(),
                        Renavam = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Veiculos", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Bicicletas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Marchas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Veiculos", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Motocicletas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Cilindradas = c.Int(nullable: false),
                        Placa = c.String(),
                        Renavam = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Veiculos", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PessoaFisica",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                        Nome = c.String(),
                        CPF = c.String(),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.PessoaJuridica",
                c => new
                    {
                        PessoaId = c.Int(nullable: false),
                        RazaoSocial = c.String(),
                        CNPJ = c.String(),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaJuridica", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.PessoaFisica", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Motocicletas", "Id", "dbo.Veiculos");
            DropForeignKey("dbo.Bicicletas", "Id", "dbo.Veiculos");
            DropForeignKey("dbo.Automoveis", "Id", "dbo.Veiculos");
            DropForeignKey("dbo.Funcionario", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Cliente", "PessoaId", "dbo.Pessoa");
            DropIndex("dbo.PessoaJuridica", new[] { "PessoaId" });
            DropIndex("dbo.PessoaFisica", new[] { "PessoaId" });
            DropIndex("dbo.Motocicletas", new[] { "Id" });
            DropIndex("dbo.Bicicletas", new[] { "Id" });
            DropIndex("dbo.Automoveis", new[] { "Id" });
            DropIndex("dbo.Funcionario", new[] { "PessoaId" });
            DropIndex("dbo.Cliente", new[] { "PessoaId" });
            DropTable("dbo.PessoaJuridica");
            DropTable("dbo.PessoaFisica");
            DropTable("dbo.Motocicletas");
            DropTable("dbo.Bicicletas");
            DropTable("dbo.Automoveis");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Cliente");
            DropTable("dbo.Veiculos");
        }
    }
}
