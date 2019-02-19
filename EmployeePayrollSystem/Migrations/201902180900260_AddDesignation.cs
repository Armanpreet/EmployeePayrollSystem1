namespace EmployeePayrollSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDesignation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        DesignId = c.Int(nullable: false),
                        Department = c.String(),
                        Mobile = c.String(),
                        Gender = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.Designations", t => t.DesignId, cascadeDelete: true)
                .Index(t => t.DesignId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DesignId", "dbo.Designations");
            DropIndex("dbo.Employees", new[] { "DesignId" });
            DropTable("dbo.Employees");
        }
    }
}
