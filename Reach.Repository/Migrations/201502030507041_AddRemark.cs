namespace Reach.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRemark : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Remark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Remark");
        }
    }
}
