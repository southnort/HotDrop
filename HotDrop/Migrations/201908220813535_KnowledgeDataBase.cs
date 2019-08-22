namespace HotDrop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KnowledgeDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        KnowledgeCell_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KnowledgeCells", t => t.KnowledgeCell_Id)
                .Index(t => t.KnowledgeCell_Id);
            
            CreateTable(
                "dbo.KnowledgeCells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.String(),
                        Description = c.String(),
                        Solution = c.String(),
                        Comments = c.String(),
                        Heat = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        KnowledgeCell_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KnowledgeCells", t => t.KnowledgeCell_Id)
                .Index(t => t.KnowledgeCell_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "KnowledgeCell_Id", "dbo.KnowledgeCells");
            DropForeignKey("dbo.DocumentTypes", "KnowledgeCell_Id", "dbo.KnowledgeCells");
            DropIndex("dbo.Tags", new[] { "KnowledgeCell_Id" });
            DropIndex("dbo.DocumentTypes", new[] { "KnowledgeCell_Id" });
            DropTable("dbo.Tags");
            DropTable("dbo.KnowledgeCells");
            DropTable("dbo.DocumentTypes");
        }
    }
}
