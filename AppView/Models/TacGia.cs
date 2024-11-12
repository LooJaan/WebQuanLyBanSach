using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppView
{
    public class TacGia
    {
        public Guid Id { get; set; }
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        public ICollection<Sach> Sachs { get; set; }
    }
}
