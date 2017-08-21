namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorNameAddedInBookModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "AuthorName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "AuthorName");
        }
    }
}
