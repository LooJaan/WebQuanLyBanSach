using System;
using System.Collections.Generic;

namespace AppData;

public partial class Account
{
    public Guid AccountId { get; set; }

    public string? UserName { get; set; }

    public string? PasswordHash { get; set; }

    public string? Role { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public Guid? KhachHangId { get; set; }

    public Guid? NhanVienId { get; set; }

    public string? TrangThai { get; set; }

    public virtual KhachHang? KhachHang { get; set; }

    public virtual NhanVien? NhanVien { get; set; }
}
