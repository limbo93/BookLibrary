namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBookType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BookTypes (Id,Name) VALUES (1,'Computer')");
            Sql("INSERT INTO BookTypes (Id,Name) VALUES (2,'Dramma')");
            Sql("INSERT INTO BookTypes (Id,Name) VALUES (3,'Travel')");
            Sql("INSERT INTO BookTypes (Id,Name) VALUES (4,'History')");
        }
        
        public override void Down()
        {
        }
    }
}
