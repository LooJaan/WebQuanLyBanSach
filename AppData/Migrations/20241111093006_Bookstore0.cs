using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class Bookstore0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_KhachHangs_KhachHangId",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_accounts_NhanViens_NhanVienId",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_donHangs_KhachHangs_KhachHangId",
                table: "donHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_Sachs_tacGias_TacGiaId",
                table: "Sachs");

            migrationBuilder.AlterColumn<Guid>(
                name: "TacGiaId",
                table: "Sachs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_KhachHangs_KhachHangId",
                table: "accounts",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_NhanViens_NhanVienId",
                table: "accounts",
                column: "NhanVienId",
                principalTable: "NhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_donHangs_KhachHangs_KhachHangId",
                table: "donHangs",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Sachs_tacGias_TacGiaId",
                table: "Sachs",
                column: "TacGiaId",
                principalTable: "tacGias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_KhachHangs_KhachHangId",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_accounts_NhanViens_NhanVienId",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_donHangs_KhachHangs_KhachHangId",
                table: "donHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_Sachs_tacGias_TacGiaId",
                table: "Sachs");

            migrationBuilder.AlterColumn<Guid>(
                name: "TacGiaId",
                table: "Sachs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_KhachHangs_KhachHangId",
                table: "accounts",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_NhanViens_NhanVienId",
                table: "accounts",
                column: "NhanVienId",
                principalTable: "NhanViens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_donHangs_KhachHangs_KhachHangId",
                table: "donHangs",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sachs_tacGias_TacGiaId",
                table: "Sachs",
                column: "TacGiaId",
                principalTable: "tacGias",
                principalColumn: "Id");
        }
    }
}
