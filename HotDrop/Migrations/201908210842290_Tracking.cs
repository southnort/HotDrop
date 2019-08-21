namespace HotDrop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tracking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrackingCells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDone = c.Int(nullable: false),
                        Number = c.String(),
                        Description = c.String(),
                        CreationDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrackingCells");
        }
    }
}
