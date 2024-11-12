using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class Bookstore00 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHangs_IdKhachHang",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangId",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVien",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_NhanVienId",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_VaiTros_IdVaiTroNavigationId",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhapCTs_PhieuNhaps_IdPhieuNhap",
                table: "PhieuNhapCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhapCTs_PhieuNhaps_PhieuNhapId",
                table: "PhieuNhapCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhaps_NhanViens_IdNhanVien",
                table: "PhieuNhaps");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhaps_NhanViens_NhanVienId",
                table: "PhieuNhaps");

            migrationBuilder.DropIndex(
                name: "IX_PhieuNhaps_IdNhanVien",
                table: "PhieuNhaps");

            migrationBuilder.DropIndex(
                name: "IX_PhieuNhapCTs_IdPhieuNhap",
                table: "PhieuNhapCTs");

            migrationBuilder.DropIndex(
                name: "IX_NhanViens_IdVaiTroNavigationId",
                table: "NhanViens");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_IdKhachHang",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_IdNhanVien",
                table: "HoaDons");

            migrationBuilder.DropColumn(
                name: "IdVaiTroNavigationId",
                table: "NhanViens");

            migrationBuilder.AlterColumn<Guid>(
                name: "NhanVienId",
                table: "PhieuNhaps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PhieuNhapId",
                table: "PhieuNhapCTs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "NhanVienId",
                table: "HoaDons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "KhachHangId",
                table: "HoaDons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "donHangs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanViens_NhanVienId",
                table: "HoaDons",
                column: "NhanVienId",
                principalTable: "NhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhapCTs_PhieuNhaps_PhieuNhapId",
                table: "PhieuNhapCTs",
                column: "PhieuNhapId",
                principalTable: "PhieuNhaps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhaps_NhanViens_NhanVienId",
                table: "PhieuNhaps",
                column: "NhanVienId",
                principalTable: "NhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangId",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NhanViens_NhanVienId",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhapCTs_PhieuNhaps_PhieuNhapId",
                table: "PhieuNhapCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhaps_NhanViens_NhanVienId",
                table: "PhieuNhaps");

            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "donHangs");

            migrationBuilder.AlterColumn<Guid>(
                name: "NhanVienId",
                table: "PhieuNhaps",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "PhieuNhapId",
                table: "PhieuNhapCTs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "IdVaiTroNavigationId",
                table: "NhanViens",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "NhanVienId",
                table: "HoaDons",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "KhachHangId",
                table: "HoaDons",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhaps_IdNhanVien",
                table: "PhieuNhaps",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhapCTs_IdPhieuNhap",
                table: "PhieuNhapCTs",
                column: "IdPhieuNhap");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IdVaiTroNavigationId",
                table: "NhanViens",
                column: "IdVaiTroNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdKhachHang",
                table: "HoaDons",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdNhanVien",
                table: "HoaDons",
                column: "IdNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_IdKhachHang",
                table: "HoaDons",
                column: "IdKhachHang",
                principalTable: "KhachHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanViens_IdNhanVien",
                table: "HoaDons",
                column: "IdNhanVien",
                principalTable: "NhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NhanViens_NhanVienId",
                table: "HoaDons",
                column: "NhanVienId",
                principalTable: "NhanViens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_VaiTros_IdVaiTroNavigationId",
                table: "NhanViens",
                column: "IdVaiTroNavigationId",
                principalTable: "VaiTros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhapCTs_PhieuNhaps_IdPhieuNhap",
                table: "PhieuNhapCTs",
                column: "IdPhieuNhap",
                principalTable: "PhieuNhaps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhapCTs_PhieuNhaps_PhieuNhapId",
                table: "PhieuNhapCTs",
                column: "PhieuNhapId",
                principalTable: "PhieuNhaps",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhaps_NhanViens_IdNhanVien",
                table: "PhieuNhaps",
                column: "IdNhanVien",
                principalTable: "NhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhaps_NhanViens_NhanVienId",
                table: "PhieuNhaps",
                column: "NhanVienId",
                principalTable: "NhanViens",
                principalColumn: "Id");
        }
    }
}
