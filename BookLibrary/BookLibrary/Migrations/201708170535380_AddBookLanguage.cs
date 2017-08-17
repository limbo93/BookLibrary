namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookLanguage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookLanguages",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Books", "BookLanguageId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Books", "BookLanguageId");
            AddForeignKey("dbo.Books", "BookLanguageId", "dbo.BookLanguages", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookLanguageId", "dbo.BookLanguages");
            DropIndex("dbo.Books", new[] { "BookLanguageId" });
            DropColumn("dbo.Books", "BookLanguageId");
            DropTable("dbo.BookLanguages");
        }
    }
}
