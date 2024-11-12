using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface ISachCTService
    {
        Task<List<SachCT>> GetAllSachCTsAsync();
        Task<SachCT> GetSachCTByIdAsync(Guid id);
        Task AddSachCTAsync(SachCT sachCT);
        Task UpdateSachCTAsync(SachCT sachCT);
        Task DeleteSachCTAsync(Guid id);
    }
}
