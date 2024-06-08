using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementWithIdentity.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddADmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'76b74d10-ccee-4c77-92ad-fa3d4a1cf5c1', N'Admin', N'ADMIN', N'Admin@admin.com', N'ADMIN@ADMIN.COM', 0, N'AQAAAAIAAYagAAAAEBJxyCq3pGJMEqK6odEkafLwyq5EamUr5h4qXaKdU6q1+yIRLWj4tYZb1IVOz4/QpA==', N'BEGLVUVR7W2Y2QBKGSZPRNPMY75KPLCD', N'208f6c91-87d8-4c4b-a324-95425b067052', null , 0, 0, NULL, 1, 0, N'Admin', N'Admin', null)\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE [Id] = '76b74d10-ccee-4c77-92ad-fa3d4a1cf5c1'");
        }
    }
}
