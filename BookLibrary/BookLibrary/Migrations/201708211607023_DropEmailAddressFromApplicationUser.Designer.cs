// <auto-generated />
namespace BookLibrary.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.0.0-20911")]
    public sealed partial class DropEmailAddressFromApplicationUser : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(DropEmailAddressFromApplicationUser));
        
        string IMigrationMetadata.Id
        {
            get { return "201708211607023_DropEmailAddressFromApplicationUser"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}