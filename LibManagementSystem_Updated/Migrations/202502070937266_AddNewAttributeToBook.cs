namespace LibManagementSystem_Updated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewAttributeToBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "ISBN", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "ISBN");
        }
    }
}
