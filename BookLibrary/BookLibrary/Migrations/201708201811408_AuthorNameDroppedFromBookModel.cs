namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorNameDroppedFromBookModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "AuthorName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "AuthorName", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
