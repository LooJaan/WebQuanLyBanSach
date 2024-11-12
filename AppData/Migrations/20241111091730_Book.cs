using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class Book : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatKhau",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "TaiKhoan",
                table: "NhanViens");

            migrationBuilder.AddColumn<Guid>(
                name: "TacGiaId",
                table: "Sachs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ChiTietDonHangId",
                table: "SachCTs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NhanVienId",
                table: "PhieuNhaps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdVaiTroNavigationId",
                table: "NhanViens",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "KhachHangId",
                table: "HoaDons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NhanVienId",
                table: "HoaDons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_accounts_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_accounts_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "donHangs",
                columns: table => new
                {
                    DonHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayDatHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donHangs", x => x.DonHangId);
                    table.ForeignKey(
                        name: "FK_donHangs_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tacGias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaTacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenTacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tacGias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "chiTietDons",
                columns: table => new
                {
                    ChiTietDonHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SachCTId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietDons", x => x.ChiTietDonHangId);
                    table.ForeignKey(
                        name: "FK_chiTietDons_donHangs_DonHangId",
                        column: x => x.DonHangId,
                        principalTable: "donHangs",
                        principalColumn: "DonHangId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_TacGiaId",
                table: "Sachs",
                column: "TacGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_SachCTs_ChiTietDonHangId",
                table: "SachCTs",
                column: "ChiTietDonHangId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhaps_NhanVienId",
                table: "PhieuNhaps",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IdVaiTroNavigationId",
                table: "NhanViens",
                column: "IdVaiTroNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_NhanVienId",
                table: "HoaDons",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_KhachHangId",
                table: "accounts",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_NhanVienId",
                table: "accounts",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietDons_DonHangId",
                table: "chiTietDons",
                column: "DonHangId");

            migrationBuilder.CreateIndex(
                name: "IX_donHangs_KhachHangId",
                table: "donHangs",
                column: "KhachHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id");

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
                name: "FK_PhieuNhaps_NhanViens_NhanVienId",
                table: "PhieuNhaps",
                column: "NhanVienId",
                principalTable: "NhanViens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SachCTs_chiTietDons_ChiTietDonHangId",
                table: "SachCTs",
                column: "ChiTietDonHangId",
                principalTable: "chiTietDons",
                principalColumn: "ChiTietDonHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sachs_tacGias_TacGiaId",
                table: "Sachs",
                column: "TacGiaId",
                principalTable: "tacGias",
                principalColumn: "Id");
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
                name: "FK_NhanViens_VaiTros_IdVaiTroNavigationId",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuNhaps_NhanViens_NhanVienId",
                table: "PhieuNhaps");

            migrationBuilder.DropForeignKey(
                name: "FK_SachCTs_chiTietDons_ChiTietDonHangId",
                table: "SachCTs");

            migrationBuilder.DropForeignKey(
                name: "FK_Sachs_tacGias_TacGiaId",
                table: "Sachs");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "chiTietDons");

            migrationBuilder.DropTable(
                name: "tacGias");

            migrationBuilder.DropTable(
                name: "donHangs");

            migrationBuilder.DropIndex(
                name: "IX_Sachs_TacGiaId",
                table: "Sachs");

            migrationBuilder.DropIndex(
                name: "IX_SachCTs_ChiTietDonHangId",
                table: "SachCTs");

            migrationBuilder.DropIndex(
                name: "IX_PhieuNhaps_NhanVienId",
                table: "PhieuNhaps");

            migrationBuilder.DropIndex(
                name: "IX_NhanViens_IdVaiTroNavigationId",
                table: "NhanViens");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_KhachHangId",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_NhanVienId",
                table: "HoaDons");

            migrationBuilder.DropColumn(
                name: "TacGiaId",
                table: "Sachs");

            migrationBuilder.DropColumn(
                name: "ChiTietDonHangId",
                table: "SachCTs");

            migrationBuilder.DropColumn(
                name: "NhanVienId",
                table: "PhieuNhaps");

            migrationBuilder.DropColumn(
                name: "IdVaiTroNavigationId",
                table: "NhanViens");

            migrationBuilder.DropColumn(
                name: "KhachHangId",
                table: "HoaDons");

            migrationBuilder.DropColumn(
                name: "NhanVienId",
                table: "HoaDons");

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
        }
    }
}
