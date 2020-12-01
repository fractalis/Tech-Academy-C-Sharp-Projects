namespace Challenge_451.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchoolWebsite : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "SchoolWebsite", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "SchoolWebsite");
        }
    }
}
