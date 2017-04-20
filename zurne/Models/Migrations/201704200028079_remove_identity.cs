namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_identity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Veiculoes");
            AlterColumn("dbo.Veiculoes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Veiculoes", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Veiculoes");
            AlterColumn("dbo.Veiculoes", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Veiculoes", "Id");
        }
    }
}
