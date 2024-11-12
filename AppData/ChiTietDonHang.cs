using System;
using System.Collections.Generic;

namespace AppData;

public partial class ChiTietDonHang
{
    public Guid ChiTietDonHangId { get; set; }

    public Guid? DonHangId { get; set; }

    public Guid? SachCTId { get; set; }


    public int? SoLuong { get; set; }

    public decimal? Gia { get; set; }

    public virtual DonHang? DonHang { get; set; }
    public virtual ICollection<SachCT> SachCTs { get; set; } = new List<SachCT>();
}
