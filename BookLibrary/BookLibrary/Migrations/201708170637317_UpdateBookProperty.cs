namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookProperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "ISBN", c => c.Long(nullable: false));
            DropColumn("dbo.Books", "EAN");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "EAN", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "ISBN", c => c.Int(nullable: false));
        }
    }
}
