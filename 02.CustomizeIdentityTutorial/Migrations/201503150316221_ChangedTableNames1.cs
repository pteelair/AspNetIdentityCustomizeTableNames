namespace _02.CustomizeIdentityTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTableNames1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Roles", newName: "Role");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Role", newName: "Roles");
        }
    }
}
