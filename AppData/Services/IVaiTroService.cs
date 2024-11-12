using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface IVaiTroService
    {
        Task<List<VaiTro>> GetAllVaiTrosAsync();
        Task<VaiTro> GetVaiTroByIdAsync(Guid id);
        Task AddVaiTroAsync(VaiTro vaiTro);
        Task UpdateVaiTroAsync(VaiTro vaiTro);
        Task DeleteVaiTroAsync(Guid id);
    }
}

