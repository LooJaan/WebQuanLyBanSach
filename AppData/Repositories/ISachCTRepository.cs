using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public interface ISachCTRepository
    {
        Task<List<SachCT>> GetAllSachCTsAsync();
        Task<SachCT> GetSachCTByIdAsync(Guid id);
        Task AddSachCTAsync(SachCT sachCT);
        Task UpdateSachCTAsync(SachCT sachCT);
        Task DeleteSachCTAsync(Guid id);
    }
}
