namespace TravelReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        ReviewTitle = c.String(),
                        FullReview = c.String(),
                        PublishDate = c.DateTime(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "CategoryID" });
            DropTable("dbo.Reviews");
        }
    }
}
