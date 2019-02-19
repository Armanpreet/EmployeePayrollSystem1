namespace EmployeePayrollSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeModification : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Designations", "DepttId", "dbo.Departments");
            DropIndex("dbo.Designations", new[] { "DepttId" });
            AddColumn("dbo.Employees", "DepttId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DepttId");
            AddForeignKey("dbo.Employees", "DepttId", "dbo.Departments", "DepttId", cascadeDelete: true);
            DropColumn("dbo.Designations", "DepttId");
            DropColumn("dbo.Employees", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Department", c => c.String());
            AddColumn("dbo.Designations", "DepttId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Employees", "DepttId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepttId" });
            DropColumn("dbo.Employees", "DepttId");
            CreateIndex("dbo.Designations", "DepttId");
            AddForeignKey("dbo.Designations", "DepttId", "dbo.Departments", "DepttId", cascadeDelete: true);
        }
    }
}
