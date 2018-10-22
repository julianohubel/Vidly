namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedusers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3bdd2674-66eb-477d-91d2-3c92aed89acb', N'juliano_hubel@hotmail.com', 0, N'AMuM3DLrxjwrVC2+wfJOwKT67fO4bDbKNVOjcbwUZesX3cLQN37AHxqySTfEonVPdA==', N'9e82068e-c4ae-411e-85be-fb8e76218c3c', NULL, 0, 0, NULL, 1, 0, N'juliano_hubel@hotmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'83164fe3-a4cf-402b-97e5-d3026d606801', N'admin@vidly.com', 0, N'AJu9iuzIguy/nu++1o11hKPCCSYqHfJbZev6nuy2g2QZIartt5cA4JiAtTsDt+5LkQ==', N'4fced598-854f-4045-9680-c6ba219ea0c9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'981b47e2-ce4a-4d80-a1c1-869e3076d5d6', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'83164fe3-a4cf-402b-97e5-d3026d606801', N'981b47e2-ce4a-4d80-a1c1-869e3076d5d6')        
               ");
        }
        
        public override void Down()
        {
        }
    }
}
