namespace Reach.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remark : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Remark");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Remark", c => c.String());
        }
    }
}
