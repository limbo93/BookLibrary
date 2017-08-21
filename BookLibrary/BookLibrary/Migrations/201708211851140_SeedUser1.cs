namespace BookLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'172d6a01-cc2f-4d21-9a66-30ad007a413f', N'manager', N'AMnOXu7UwSRscNxnPNx76OeI/VX7wGs03Ln15j119zKpkYN4rQ0o9TO63Gdk34NwUA==', N'5dbffd97-0715-4934-9d08-1ef43d958c57', N'ApplicationUser')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'1d2d691e-6b82-474d-b877-32ab46c91893', N'admin', N'AAchT5ZMP5dNmJ5N2OXl4mNCO8oaghE63kEMvCFkOSHEho9L9wRRycJijonH2s/daA==', N'060ba783-4130-46e1-b3cc-47bc9d5f2b2b', N'ApplicationUser')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'2ce13cc5-7443-42d0-ac3b-fe47bbb8d3b8', N'guest', N'AOj4w3KPOn7/OIA5tmCFDBlgA6JsFAOyqSWXf6xY1hmFVoxFNqLA+WkR5Q6Optsl0w==', N'feda781a-afb3-4448-890f-0ceae383cd1e', N'ApplicationUser')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ccf69299-6085-439d-ba32-0753bf7afaf1', N'CanManageBook')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd6b8c040-7fde-4892-8a50-5238a5113832', N'CanManageCustomers')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'172d6a01-cc2f-4d21-9a66-30ad007a413f', N'd6b8c040-7fde-4892-8a50-5238a5113832')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1d2d691e-6b82-474d-b877-32ab46c91893', N'ccf69299-6085-439d-ba32-0753bf7afaf1')
");
        }
        
        public override void Down()
        {
        }
    }
}
