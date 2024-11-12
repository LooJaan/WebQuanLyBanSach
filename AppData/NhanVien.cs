using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public string MaNhanVien { get; set; } // Employee Code
        public string TenNhanVien { get; set; } // Employee Name
        public string SDT { get; set; } // Phone Number
        public string DiaChi { get; set; } // Address
        public string CCCD { get; set; } // National ID
        public DateTime NgaySinh { get; set; } // Date of Birth
        public Guid IdVaiTro { get; set; } // Role ID
        public VaiTro VaiTro { get; set; } // Role

        public string GioiTinh { get; set; } // Gender
      

        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();
       
    }

}
