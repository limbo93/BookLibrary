namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBookLanguage : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BookLanguages (Id, Name) VALUES (1,'Bengali')");
            Sql("INSERT INTO BookLanguages (Id, Name) VALUES (2,'English')");
            Sql("INSERT INTO BookLanguages (Id, Name) VALUES (3,'Spanish')");
        }
        
        public override void Down()
        {
        }
    }
}
