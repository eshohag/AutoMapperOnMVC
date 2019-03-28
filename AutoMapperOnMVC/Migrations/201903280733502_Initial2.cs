namespace AutoMapperOnMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "DepartmentName", c => c.String());
            AddColumn("dbo.Teachers", "FName", c => c.String());
            AddColumn("dbo.Teachers", "LName", c => c.String());
            AddColumn("dbo.Teachers", "DepartmentName", c => c.String());
            DropColumn("dbo.Teachers", "FirstName");
            DropColumn("dbo.Teachers", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "LastName", c => c.String());
            AddColumn("dbo.Teachers", "FirstName", c => c.String());
            DropColumn("dbo.Teachers", "DepartmentName");
            DropColumn("dbo.Teachers", "LName");
            DropColumn("dbo.Teachers", "FName");
            DropColumn("dbo.Students", "DepartmentName");
        }
    }
}
