using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppView
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public int SDT { get; set; }
        public string DiaChi { get; set; }
    }
}
