using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class Sach
    {
        public Guid Id { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuongTon { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }
        public int TongSoTap { get; set; } // Cột Tổng số tập
        public Guid IdTheLoai { get; set; } // Khóa ngoại đến bảng Thể Loại
        public Guid IdNXB { get; set; } // Khóa ngoại đến bảng Nhà Xuất Bản
        public Guid IdNgonNgu { get; set; } // Khóa ngoại đến bảng Ngôn Ngữ
        public Guid TacGiaId { get; set; }
        public TacGia TacGia { get; set; }
        public TheLoai TheLoai { get; set; } // Navigation property đến bảng Thể Loại
        public NhaXuatBan NhaXuatBan { get; set; } // Navigation property đến bảng Nhà Xuất Bản
        public NgonNgu NgonNgu { get; set; } // Navigation property đến bảng Ngôn Ngữ
    }
}
