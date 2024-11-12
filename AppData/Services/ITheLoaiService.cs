using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface ITheLoaiService
    {
        Task<List<TheLoai>> GetAllTheLoaisAsync();
        Task<TheLoai> GetTheLoaiByIdAsync(Guid id);
        Task AddTheLoaiAsync(TheLoai theLoai);
        Task UpdateTheLoaiAsync( TheLoai theLoai);
        Task DeleteTheLoaiAsync(Guid id);
    }
}
