using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppView
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int SDT { get; set; }
        public string DiaChi { get; set; }
        public string CCCD { get; set; }
        public DateTime NgaySinh { get; set; }
        public Guid IdVaiTro { get; set; }
        public VaiTro VaiTro { get; set; }
    }
}
