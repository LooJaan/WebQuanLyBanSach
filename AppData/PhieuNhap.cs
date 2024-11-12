using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class PhieuNhap
    {
        public Guid Id { get; set; }
        public string MaPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public float TongTien { get; set; }
        public Guid IdNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }
        public List<PhieuNhapCT> ChiTietPhieuNhaps { get; set; }
        public Guid NhaCungCapId { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public string LyDoNhap { get; set; } // Lý do nhập hàng

        public void TinhTongTien()
        {
            TongTien = ChiTietPhieuNhaps.Sum(ct => ct.Gia * ct.SoLuong);
        }
    }
}
