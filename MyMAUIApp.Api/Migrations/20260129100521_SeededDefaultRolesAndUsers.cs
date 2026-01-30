using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyMAUIApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "IdentityUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "IdentityUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "IdentityRoles");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "IdentityUserRoles",
                newName: "IX_IdentityUserRoles_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUsers",
                table: "IdentityUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserRoles",
                table: "IdentityUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityRoles",
                table: "IdentityRoles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "IdentityRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "hiuwerhg7yjb72", "00000000-0000-0000-0000-000000000002", "User", "USER" },
                    { "hiuwerhg7yjb78", "00000000-0000-0000-0000-000000000001", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "da3b3133-056a-4c3a-99a5-29ad9925934a", 0, "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMOCKED_ADMIN_HASH", null, false, "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa", false, "admin@localhost.com" },
                    { "ea293138-f814-4d80-98f7-edba139c719f", 0, "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMOCKED_USER_HASH", null, false, "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "hiuwerhg7yjb78", "da3b3133-056a-4c3a-99a5-29ad9925934a" },
                    { "hiuwerhg7yjb72", "ea293138-f814-4d80-98f7-edba139c719f" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_IdentityRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "IdentityRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_IdentityUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "IdentityUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_IdentityUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "IdentityUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_IdentityUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "IdentityUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRoles_IdentityRoles_RoleId",
                table: "IdentityUserRoles",
                column: "RoleId",
                principalTable: "IdentityRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRoles_IdentityUsers_UserId",
                table: "IdentityUserRoles",
                column: "UserId",
                principalTable: "IdentityUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_IdentityRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_IdentityUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_IdentityUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_IdentityUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRoles_IdentityRoles_RoleId",
                table: "IdentityUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRoles_IdentityUsers_UserId",
                table: "IdentityUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUsers",
                table: "IdentityUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserRoles",
                table: "IdentityUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityRoles",
                table: "IdentityRoles");

            migrationBuilder.DeleteData(
                table: "IdentityUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "hiuwerhg7yjb78", "da3b3133-056a-4c3a-99a5-29ad9925934a" });

            migrationBuilder.DeleteData(
                table: "IdentityUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "hiuwerhg7yjb72", "ea293138-f814-4d80-98f7-edba139c719f" });

            migrationBuilder.DeleteData(
                table: "IdentityRoles",
                keyColumn: "Id",
                keyValue: "hiuwerhg7yjb72");

            migrationBuilder.DeleteData(
                table: "IdentityRoles",
                keyColumn: "Id",
                keyValue: "hiuwerhg7yjb78");

            migrationBuilder.DeleteData(
                table: "IdentityUsers",
                keyColumn: "Id",
                keyValue: "da3b3133-056a-4c3a-99a5-29ad9925934a");

            migrationBuilder.DeleteData(
                table: "IdentityUsers",
                keyColumn: "Id",
                keyValue: "ea293138-f814-4d80-98f7-edba139c719f");

            migrationBuilder.RenameTable(
                name: "IdentityUsers",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "IdentityUserRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "IdentityRoles",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityUserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
