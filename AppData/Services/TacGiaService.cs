using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class TacGiaService : ITacGiaService
    {
        private readonly ITacGiaRepository _tacGiaRepository;

        public TacGiaService(ITacGiaRepository tacGiaRepository)
        {
            _tacGiaRepository = tacGiaRepository;
        }

        public async Task<IEnumerable<TacGia>> GetAllTacGiasAsync()
        {
            return await _tacGiaRepository.GetAllTacGiasAsync();
        }

        public async Task<TacGia> GetTacGiaByIdAsync(Guid id)
        {
            return await _tacGiaRepository.GetTacGiaByIdAsync(id);
        }

        public async Task AddTacGiaAsync(TacGia tacGia)
        {
            await _tacGiaRepository.AddTacGiaAsync(tacGia);
        }

        public async Task UpdateTacGiaAsync(TacGia tacGia)
        {
            await _tacGiaRepository.UpdateTacGiaAsync(tacGia);
        }

        public async Task DeleteTacGiaAsync(Guid id)
        {
            await _tacGiaRepository.DeleteTacGiaAsync(id);
        }
    }

}
