namespace Examen_ASP.Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_Product_Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Address", c => c.String());
            AddColumn("dbo.Products", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Status");
            DropColumn("dbo.Products", "Address");
        }
    }
}
