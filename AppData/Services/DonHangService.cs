using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class DonHangService : IDonHangService
    {
        private readonly IDonHangRepository _donHangRepository;

        public DonHangService(IDonHangRepository donHangRepository)
        {
            _donHangRepository = donHangRepository;
        }

        public async Task<IEnumerable<DonHang>> GetAllDonHangsAsync()
        {
            return await _donHangRepository.GetAllDonHangsAsync();
        }

        public async Task<DonHang> GetDonHangByIdAsync(Guid id)
        {
            return await _donHangRepository.GetDonHangByIdAsync(id);
        }

        public async Task AddDonHangAsync(DonHang donHang)
        {
            await _donHangRepository.AddDonHangAsync(donHang);
        }

        public async Task UpdateDonHangAsync(DonHang donHang)
        {
            await _donHangRepository.UpdateDonHangAsync(donHang);
        }

        public async Task DeleteDonHangAsync(Guid id)
        {
            await _donHangRepository.DeleteDonHangAsync(id);
        }
    }

}
