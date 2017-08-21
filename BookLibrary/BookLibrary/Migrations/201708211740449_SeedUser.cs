namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'1d2d691e-6b82-474d-b877-32ab46c91893', N'admin', N'AAchT5ZMP5dNmJ5N2OXl4mNCO8oaghE63kEMvCFkOSHEho9L9wRRycJijonH2s/daA==', N'060ba783-4130-46e1-b3cc-47bc9d5f2b2b', N'ApplicationUser')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'2ce13cc5-7443-42d0-ac3b-fe47bbb8d3b8', N'guest', N'AOj4w3KPOn7/OIA5tmCFDBlgA6JsFAOyqSWXf6xY1hmFVoxFNqLA+WkR5Q6Optsl0w==', N'feda781a-afb3-4448-890f-0ceae383cd1e', N'ApplicationUser')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ccf69299-6085-439d-ba32-0753bf7afaf1', N'CanManageBook')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1d2d691e-6b82-474d-b877-32ab46c91893', N'ccf69299-6085-439d-ba32-0753bf7afaf1')
");
        }
        
        public override void Down()
        {
        }
    }
}
