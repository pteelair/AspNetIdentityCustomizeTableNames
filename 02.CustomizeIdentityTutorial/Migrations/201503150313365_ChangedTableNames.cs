namespace _02.CustomizeIdentityTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTableNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetRoles", newName: "Roles");
            RenameTable(name: "dbo.AspNetUserRoles", newName: "UserRole");
            RenameTable(name: "dbo.AspNetUsers", newName: "User");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "UserClaim");
            RenameTable(name: "dbo.AspNetUserLogins", newName: "UserLoging");
            RenameColumn(table: "dbo.User", name: "Id", newName: "Primary_Key");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.User", name: "Primary_Key", newName: "Id");
            RenameTable(name: "dbo.UserLoging", newName: "AspNetUserLogins");
            RenameTable(name: "dbo.UserClaim", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.User", newName: "AspNetUsers");
            RenameTable(name: "dbo.UserRole", newName: "AspNetUserRoles");
            RenameTable(name: "dbo.Roles", newName: "AspNetRoles");
        }
    }
}
