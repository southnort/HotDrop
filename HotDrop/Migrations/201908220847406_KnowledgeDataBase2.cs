namespace HotDrop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KnowledgeDataBase2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DocumentTypes", "KnowledgeCell_Id", "dbo.KnowledgeCells");
            DropForeignKey("dbo.Tags", "KnowledgeCell_Id", "dbo.KnowledgeCells");
            DropIndex("dbo.DocumentTypes", new[] { "KnowledgeCell_Id" });
            DropIndex("dbo.Tags", new[] { "KnowledgeCell_Id" });
            CreateTable(
                "dbo.KnowledgeCellDocumentTypes",
                c => new
                    {
                        KnowledgeCell_Id = c.Int(nullable: false),
                        DocumentType_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KnowledgeCell_Id, t.DocumentType_Id })
                .ForeignKey("dbo.KnowledgeCells", t => t.KnowledgeCell_Id, cascadeDelete: true)
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentType_Id, cascadeDelete: true)
                .Index(t => t.KnowledgeCell_Id)
                .Index(t => t.DocumentType_Id);
            
            CreateTable(
                "dbo.TagKnowledgeCells",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        KnowledgeCell_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.KnowledgeCell_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.KnowledgeCells", t => t.KnowledgeCell_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.KnowledgeCell_Id);
            
            DropColumn("dbo.DocumentTypes", "KnowledgeCell_Id");
            DropColumn("dbo.Tags", "KnowledgeCell_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tags", "KnowledgeCell_Id", c => c.Int());
            AddColumn("dbo.DocumentTypes", "KnowledgeCell_Id", c => c.Int());
            DropForeignKey("dbo.TagKnowledgeCells", "KnowledgeCell_Id", "dbo.KnowledgeCells");
            DropForeignKey("dbo.TagKnowledgeCells", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.KnowledgeCellDocumentTypes", "DocumentType_Id", "dbo.DocumentTypes");
            DropForeignKey("dbo.KnowledgeCellDocumentTypes", "KnowledgeCell_Id", "dbo.KnowledgeCells");
            DropIndex("dbo.TagKnowledgeCells", new[] { "KnowledgeCell_Id" });
            DropIndex("dbo.TagKnowledgeCells", new[] { "Tag_Id" });
            DropIndex("dbo.KnowledgeCellDocumentTypes", new[] { "DocumentType_Id" });
            DropIndex("dbo.KnowledgeCellDocumentTypes", new[] { "KnowledgeCell_Id" });
            DropTable("dbo.TagKnowledgeCells");
            DropTable("dbo.KnowledgeCellDocumentTypes");
            CreateIndex("dbo.Tags", "KnowledgeCell_Id");
            CreateIndex("dbo.DocumentTypes", "KnowledgeCell_Id");
            AddForeignKey("dbo.Tags", "KnowledgeCell_Id", "dbo.KnowledgeCells", "Id");
            AddForeignKey("dbo.DocumentTypes", "KnowledgeCell_Id", "dbo.KnowledgeCells", "Id");
        }
    }
}
