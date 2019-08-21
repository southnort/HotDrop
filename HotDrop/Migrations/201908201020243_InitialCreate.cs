namespace HotDrop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CallCells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inn = c.String(),
                        ClientName = c.String(),
                        PhoneNumber = c.String(),
                        Descr = c.String(),
                        CallDateTime = c.String(),
                        Logged = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CallCells");
        }
    }
}
