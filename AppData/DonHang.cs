using System;
using System.Collections.Generic;

namespace AppData;

public partial class DonHang
{
    public Guid DonHangId { get; set; }

    public Guid? KhachHangId { get; set; }

    public DateTime? NgayDatHang { get; set; }

    public decimal? TongTien { get; set; }

    public string? TrangThai { get; set; }
    public string DiaChi { get; set; }

    public string? PhuongThucThanhToan { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual KhachHang? KhachHang { get; set; }
}
