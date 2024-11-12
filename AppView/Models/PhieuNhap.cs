using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppView
{
    public class PhieuNhap
    {
        public Guid Id { get; set; }
        public string MaPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public float TongTien { get; set; }
        public Guid IdNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
