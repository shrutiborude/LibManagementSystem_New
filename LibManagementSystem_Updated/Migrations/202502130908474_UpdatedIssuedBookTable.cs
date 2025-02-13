namespace LibManagementSystem_Updated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedIssuedBookTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IssuedBooks", "RequestStatus", c => c.String());
            DropColumn("dbo.IssuedBooks", "RequestSatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IssuedBooks", "RequestSatus", c => c.String());
            DropColumn("dbo.IssuedBooks", "RequestStatus");
        }
    }
}
