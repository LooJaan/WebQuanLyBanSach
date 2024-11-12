using AppData;
using AppData.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [ApiController]
    [Route("api/nhaxuatban")]
    public class NhaXuatBanController : ControllerBase
    {
        private readonly INhaXuatBanService _nhaXuatBanService;

        public NhaXuatBanController(INhaXuatBanService nhaXuatBanService)
        {
            _nhaXuatBanService = nhaXuatBanService;
        }

        // GET api/nhaxuatban
        [HttpGet]
        public async Task<ActionResult<List<NhaXuatBan>>> GetAllNhaXuatBans()
        {
            var nhaXuatBans = await _nhaXuatBanService.GetAllNhaXuatBansAsync();
            return Ok(nhaXuatBans);
        }

        // GET api/nhaxuatban/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<NhaXuatBan>> GetNhaXuatBanById(Guid id)
        {
            var nhaXuatBan = await _nhaXuatBanService.GetNhaXuatBanByIdAsync(id);
            if (nhaXuatBan == null)
            {
                return NotFound();
            }
            return Ok(nhaXuatBan);
        }

        // POST api/nhaxuatban
        [HttpPost]
        public async Task<ActionResult> AddNhaXuatBan([FromBody] NhaXuatBan nhaXuatBan)
        {
            nhaXuatBan.Id = Guid.NewGuid();
            await _nhaXuatBanService.AddNhaXuatBanAsync(nhaXuatBan);
            return CreatedAtAction(nameof(GetNhaXuatBanById), new { id = nhaXuatBan.Id }, nhaXuatBan);
        }

        // PUT api/nhaxuatban/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateNhaXuatBan(Guid id, [FromBody] NhaXuatBan nhaXuatBan)
        {
            if (id != nhaXuatBan.Id)
            {
                return BadRequest();
            }

            try
            {
                await _nhaXuatBanService.UpdateNhaXuatBanAsync(nhaXuatBan);
                return NoContent();  // Trả về HTTP 204 nếu cập nhật thành công
            }
            catch (KeyNotFoundException)
            {
                return NotFound();  // Nếu không tìm thấy, trả về HTTP 404
            }
        }

        // DELETE api/nhaxuatban/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNhaXuatBan(Guid id)
        {
            await _nhaXuatBanService.DeleteNhaXuatBanAsync(id);
            return NoContent();  // Trả về HTTP 204 khi xóa thành công
        }
    }

}
