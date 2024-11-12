using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppView
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public DateTime NgayXuatHang { get; set; }
        public float TongTien { get; set; }
        public Guid IdKhachHang { get; set; }
        public KhachHang KhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
