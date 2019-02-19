namespace EmployeePayrollSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSalary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salaries", "BasicSalary", c => c.Double(nullable: false));
            AddColumn("dbo.Salaries", "Taxes", c => c.Double(nullable: false));
            AddColumn("dbo.Salaries", "TotalSalary", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Salaries", "TotalSalary");
            DropColumn("dbo.Salaries", "Taxes");
            DropColumn("dbo.Salaries", "BasicSalary");
        }
    }
}
