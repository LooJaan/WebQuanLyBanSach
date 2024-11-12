using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class BookStore2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_VaiTro_IdVaiTro",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaiTro",
                table: "VaiTro");

            migrationBuilder.RenameTable(
                name: "VaiTro",
                newName: "VaiTros");

            migrationBuilder.AddColumn<string>(
                name: "LyDoNhap",
                table: "PhieuNhaps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "NhaCungCapId",
                table: "PhieuNhaps",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PhieuNhapId",
                table: "PhieuNhapCTs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GioiTinh",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MatKhau",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TaiKhoan",
                table: "NhanViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaiTros",
                table: "VaiTros",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "NhaCungCaps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCaps", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhaps_NhaCungCapId",
                table: "PhieuNhaps",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhapCTs_PhieuNhapId",
                table: "PhieuNhapCTs",
                column: "PhieuNhapId");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_VaiTros_IdVaiTro",
                table: "NhanViens",
                column: "IdVaiTro",
                principalTable: "VaiTros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhapCTs_PhieuNhaps_PhieuNhapId",
                table: "PhieuNhapCTs",
                column: "PhieuNhapId",
                principalTable: "PhieuNhaps",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuNhaps_NhaCungCaps_NhaCungCapId",
                table: "PhieuNhaps",
                column: "NhaCungCapId",
                principalTable: "NhaCungCaps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_VaiTros_IdVaiTro",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhapCTs_PhieuNhaps_PhieuNhapId",
                table: "PhieuNhapCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhaps_NhaCungCaps_NhaCungCapId",
                table: "PhieuNhaps");

            migrationBuilder.DropTable(
                name: "NhaCungCaps");

            migrationBuilder.DropIndex(
                name: "IX_PhieuNhaps_NhaCungCapId",
                table: "PhieuNhaps");

            migrationBuilder.DropIndex(
                name: "IX_PhieuNhapCTs_PhieuNhapId",
                table: "PhieuNhapCTs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaiTros",
                table: "VaiTros");

            migrationBuilder.DropColumn(
                name: "LyDoNhap",
                table: "PhieuNhaps");

            migrationBuilder.DropColumn(
                name: "NhaCungCapId",
                table: "PhieuNhaps");

            migrationBuilder.DropColumn(
                name: "PhieuNhapId",
                table: "PhieuNhapCTs");

            migrationBuilder.DropColumn(
                name: "GioiTinh",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "MatKhau",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "TaiKhoan",
                table: "NhanViens");

            migrationBuilder.RenameTable(
                name: "VaiTros",
                newName: "VaiTro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaiTro",
                table: "VaiTro",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_VaiTro_IdVaiTro",
                table: "NhanViens",
                column: "IdVaiTro",
                principalTable: "VaiTro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
