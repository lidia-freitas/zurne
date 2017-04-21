namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class automovel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculoes", "Autonomia", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veiculoes", "Autonomia");
        }
    }
}
