namespace Challenge_451.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        SchoolAddress = c.String(),
                        SchoolCity = c.String(),
                        SchoolState = c.String(),
                        SchoolZip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        Gpa = c.Double(nullable: false),
                        SchoolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectType = c.Int(nullable: false),
                        SubjectName = c.String(),
                        Student_StudentId = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.Students", t => t.Student_StudentId)
                .Index(t => t.Student_StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "SchoolId", "dbo.Schools");
            DropIndex("dbo.Subjects", new[] { "Student_StudentId" });
            DropIndex("dbo.Students", new[] { "SchoolId" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
            DropTable("dbo.Schools");
        }
    }
}
