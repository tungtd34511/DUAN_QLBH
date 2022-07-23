using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class QLBH_22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ACCOUNT_Acc",
                table: "ACCOUNT",
                column: "Acc",
                unique: true,
                filter: "[Acc] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ACCOUNT_Acc",
                table: "ACCOUNT");
        }
    }
}
