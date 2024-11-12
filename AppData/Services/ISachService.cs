using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface ISachService
    {
        Task<List<Sach>> GetAllSachsAsync();
        Task<Sach> GetSachByIdAsync(Guid id);
        Task AddSachAsync(Sach sach);
        Task UpdateSachAsync(Sach sach);
        Task DeleteSachAsync(Guid id);
    }
}

