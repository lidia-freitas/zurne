namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addVeiculos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Cor = c.String(),
                        Ano = c.Int(nullable: false),
                        Potencia = c.Double(),
                        Placa = c.String(),
                        Renavam = c.String(),
                        Marchas = c.Int(),
                        Cilindradas = c.Int(),
                        Placa1 = c.String(),
                        Renavam1 = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Veiculoes");
        }
    }
}
