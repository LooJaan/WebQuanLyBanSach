using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
        public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();

        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }
}
