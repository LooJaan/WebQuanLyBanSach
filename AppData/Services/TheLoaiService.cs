using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class TheLoaiService : ITheLoaiService
    {
        private readonly ITheLoaiRepository _theLoaiRepository;

        public TheLoaiService(ITheLoaiRepository theLoaiRepository)
        {
            _theLoaiRepository = theLoaiRepository;
        }

        // Lấy tất cả thể loại
        public async Task<List<TheLoai>> GetAllTheLoaisAsync()
        {
            return await _theLoaiRepository.GetAllTheLoaisAsync();
        }

        // Lấy thể loại theo ID
        public async Task<TheLoai> GetTheLoaiByIdAsync(Guid id)
        {
            return await _theLoaiRepository.GetTheLoaiByIdAsync(id);
        }

        // Thêm thể loại mới
        public async Task AddTheLoaiAsync(TheLoai theLoai)
        {
            await _theLoaiRepository.AddTheLoaiAsync(theLoai);
        }

        // Cập nhật thể loại
        public async Task UpdateTheLoaiAsync(TheLoai theLoai)
        {
            await _theLoaiRepository.UpdateTheLoaiAsync(theLoai);
        }

        // Xóa thể loại
        public async Task DeleteTheLoaiAsync(Guid id)
        {
            await _theLoaiRepository.DeleteTheLoaiAsync(id);
        }
    }
}
