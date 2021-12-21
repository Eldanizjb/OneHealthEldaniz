using Microsoft.EntityFrameworkCore.Migrations;

namespace OneHealth.Migrations
{
    public partial class CommentTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_DoctorId",
                table: "Comment",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Doctor_DoctorId",
                table: "Comment",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Doctor_DoctorId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_DoctorId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Comment");
        }
    }
}
