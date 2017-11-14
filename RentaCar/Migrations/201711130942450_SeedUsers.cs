namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b9af3bd9-7f17-421b-b482-1cda3a39d953', N'guest@gmail.com', 0, N'AP6NWzcQgkragbzUxVUQbuNVX7yiZfxaanzsLt+ny7NJdsw9ZiGJQkLmKkhCTBuoaw==', N'47f82768-68f3-4e87-81ae-2b522be745a0', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cc55c34b-d732-41be-a34a-2d3ddbef70c6', N'admin@gmail.com', 0, N'APLM0GKFLidQCTKfgliaabSubLK44EENyKwx0MRWLb0rcU/dsYrUnSN7sYf2klqEJw==', N'30354fa9-f4ac-4da5-aa19-687777c40490', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'038ab5ce-1344-400c-b1c6-d0b749e9b00e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cc55c34b-d732-41be-a34a-2d3ddbef70c6', N'038ab5ce-1344-400c-b1c6-d0b749e9b00e')

");
        }
        
        public override void Down()
        {
        }
    }
}
