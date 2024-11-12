using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class SachCT
    {
        public Guid Id { get; set; }
        public string MaSachCT { get; set; }
        public int SoLuong { get; set; }
        public Guid IdSach { get; set; }
        public string TrangThai { get; set; }  
        public float GiaBan { get; set; }     

        // Navigation property để liên kết với bảng Sách
        public Sach Sach { get; set; }
    }
}
