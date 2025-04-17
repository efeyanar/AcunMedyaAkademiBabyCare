using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunMedyaAkademiBabyCare.Migrations
{
    public partial class mig_iliski : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "AboutLists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_BranchId",
                table: "Teams",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Branches_BranchId",
                table: "Teams",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Branches_BranchId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_BranchId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "Title",
                table: "AboutLists",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
