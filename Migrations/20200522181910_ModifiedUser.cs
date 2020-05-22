using Microsoft.EntityFrameworkCore.Migrations;

namespace condominio_core_api.Migrations
{
    public partial class ModifiedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdentificationNumber",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
