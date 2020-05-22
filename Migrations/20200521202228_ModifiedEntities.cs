using Microsoft.EntityFrameworkCore.Migrations;

namespace condominio_core_api.Migrations
{
    public partial class ModifiedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Users_UserId",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "People");

            migrationBuilder.RenameIndex(
                name: "IX_Person_UserId",
                table: "People",
                newName: "IX_People_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Services",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Services",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Companies",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Companies",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Users_UserId",
                table: "People",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Users_UserId",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_People_UserId",
                table: "Person",
                newName: "IX_Person_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Users_UserId",
                table: "Person",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
