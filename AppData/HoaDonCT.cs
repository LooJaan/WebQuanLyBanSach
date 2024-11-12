using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class HoaDonCT
    {
        public Guid Id { get; set; }
        public float Gia { get; set; }
        public int SoLuong { get; set; }
        public Guid IdSachCT { get; set; }
        public SachCT SachCT { get; set; }
        public Guid IdHoaDon { get; set; }
        public HoaDon HoaDon { get; set; }
    }
}
