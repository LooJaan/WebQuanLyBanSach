using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {
        }
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<NgonNgu> NgonNgus { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<SachCT> SachCTs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonCT> HoaDonCTs { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; } 
        public DbSet<PhieuNhapCT> PhieuNhapCTs { get; set; }
        public DbSet<TacGia> tacGias { get; set; }
        public DbSet<DonHang> donHangs { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<ChiTietDonHang> chiTietDons { get; set; }

        // Cấu hình chuỗi kết nối đến cơ sở dữ liệu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NOONE\MSSQLSERVER02;Database=BookStore;Trusted_Connection=True;TrustServerCertificate=True");
        }

        // Cấu hình các mối quan hệ
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Quan hệ giữa VaiTro và NhanVien (1 VaiTro -> nhiều NhanVien)
            modelBuilder.Entity<NhanVien>()
                .HasOne(n => n.VaiTro)
                .WithMany()
                .HasForeignKey(n => n.IdVaiTro);

            // Quan hệ giữa TheLoai và Sach (1 TheLoai -> nhiều Sach)
            modelBuilder.Entity<Sach>()
                .HasOne(s => s.TheLoai)
                .WithMany()
                .HasForeignKey(s => s.IdTheLoai);

            // Quan hệ giữa NhaXuatBan và Sach (1 NhaXuatBan -> nhiều Sach)
            modelBuilder.Entity<Sach>()
                .HasOne(s => s.NhaXuatBan)
                .WithMany()
                .HasForeignKey(s => s.IdNXB);

            // Quan hệ giữa NgonNgu và Sach (1 NgonNgu -> nhiều Sach)
            modelBuilder.Entity<Sach>()
                .HasOne(s => s.NgonNgu)
                .WithMany()
                .HasForeignKey(s => s.IdNgonNgu);

            // Quan hệ giữa HoaDon và KhachHang (1 KhachHang -> nhiều HoaDon)
      /*      modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.KhachHang)
                .WithMany()
                .HasForeignKey(h => h.IdKhachHang);*/

            // Quan hệ giữa HoaDon và NhanVien (1 NhanVien -> nhiều HoaDon)
           /* modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.NhanVien)
                .WithMany()
                .HasForeignKey(h => h.IdNhanVien);
*/
            // Quan hệ giữa HoaDonCT và HoaDon (1 HoaDon -> nhiều HoaDonCT)
            modelBuilder.Entity<HoaDonCT>()
                .HasOne(hd => hd.HoaDon)
                .WithMany()
                .HasForeignKey(hd => hd.IdHoaDon);

            // Quan hệ giữa HoaDonCT và SachCT (1 SachCT -> nhiều HoaDonCT)
            modelBuilder.Entity<HoaDonCT>()
                .HasOne(hd => hd.SachCT)
                .WithMany()
                .HasForeignKey(hd => hd.IdSachCT);

            // Quan hệ giữa PhieuNhap và NhanVien (1 NhanVien -> nhiều PhieuNhap)
           /* modelBuilder.Entity<PhieuNhap>()
                .HasOne(p => p.NhanVien)
                .WithMany()
                .HasForeignKey(p => p.IdNhanVien);*/

            // Quan hệ giữa PhieuNhap và NhaCungCap (1 NhaCungCap -> nhiều PhieuNhap)
            modelBuilder.Entity<PhieuNhap>()
                .HasOne(p => p.NhaCungCap) // Thiết lập mối quan hệ với NhaCungCap
                .WithMany() // Một nhà cung cấp có thể có nhiều phiếu nhập
                .HasForeignKey(p => p.NhaCungCapId); // Khoá ngoại đến NhaCungCap

            // Quan hệ giữa PhieuNhapCT và PhieuNhap (1 PhieuNhap -> nhiều PhieuNhapCT)
    /*        modelBuilder.Entity<PhieuNhapCT>()
                .HasOne(pn => pn.PhieuNhap)
                .WithMany()
                .HasForeignKey(pn => pn.IdPhieuNhap);*/

            // Quan hệ giữa PhieuNhapCT và SachCT (1 SachCT -> nhiều PhieuNhapCT)
            modelBuilder.Entity<PhieuNhapCT>()
                .HasOne(pn => pn.SachCT)
                .WithMany()
                .HasForeignKey(pn => pn.IdSachCT);

            // Quan hệ giữa Sach và SachCT (1 Sach -> nhiều SachCT)
            modelBuilder.Entity<SachCT>()
                .HasOne(sct => sct.Sach)
                .WithMany()
                .HasForeignKey(sct => sct.IdSach);
            // Mối quan hệ giữa TaiKhoan và KhachHang
            modelBuilder.Entity<Account>()
                .HasOne(tk => tk.KhachHang)
                .WithMany(kh => kh.Accounts)
                .HasForeignKey(tk => tk.KhachHangId)
                .OnDelete(DeleteBehavior.SetNull); // Chọn hành vi khi xóa KhachHang

            // Mối quan hệ giữa TaiKhoan và NhanVien
            modelBuilder.Entity<Account>()
                .HasOne(tk => tk.NhanVien)
                .WithMany(nv => nv.Accounts)
                .HasForeignKey(tk => tk.NhanVienId)
                .OnDelete(DeleteBehavior.SetNull); // Chọn hành vi khi xóa NhanVien
                                                   // Mối quan hệ giữa DonHang và KhachHang
            modelBuilder.Entity<DonHang>()
                .HasOne(dh => dh.KhachHang) // DonHang có một KhachHang
                .WithMany(kh => kh.DonHangs) // KhachHang có nhiều DonHang
                .HasForeignKey(dh => dh.KhachHangId) // Khóa ngoại của DonHang trỏ đến KhachHangId
                .OnDelete(DeleteBehavior.SetNull); // Khi KhachHang bị xóa, sẽ đặt KhachHangId của DonHang thành null

            // Mối quan hệ giữa DonHang và ChiTietDonHang
            modelBuilder.Entity<DonHang>()
                .HasMany(dh => dh.ChiTietDonHangs) // DonHang có nhiều ChiTietDonHang
                .WithOne(ctdh => ctdh.DonHang) // ChiTietDonHang chỉ thuộc về một DonHang
                .HasForeignKey(ctdh => ctdh.DonHangId); // Khóa ngoại của ChiTietDonHang trỏ đến DonHangId
                                                        // Mối quan hệ giữa TacGia và Sach
            modelBuilder.Entity<Sach>()
               .HasOne(s => s.TacGia)  // Sach có một TacGia
               .WithMany(tg => tg.Sachs) // TacGia có nhiều Sach
               .HasForeignKey(s => s.TacGiaId); // Khóa ngoại của Sach trỏ đến TacGiaId

            base.OnModelCreating(modelBuilder);
        }
    }
}
