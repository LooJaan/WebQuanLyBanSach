using AppData;
using AppData.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [ApiController]
    [Route("api/tacgia")]
    public class TacGiaController : ControllerBase
    {
        private readonly ITacGiaService _tacGiaService;

        public TacGiaController(ITacGiaService tacGiaService)
        {
            _tacGiaService = tacGiaService;
        }

        // GET api/tacgia
        [HttpGet]
        public async Task<ActionResult<List<TacGia>>> GetAllTacGias()
        {
            var tacGias = await _tacGiaService.GetAllTacGiasAsync();
            return Ok(tacGias);
        }

        // GET api/tacgia/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TacGia>> GetTacGiaById(Guid id)
        {
            var tacGia = await _tacGiaService.GetTacGiaByIdAsync(id);
            if (tacGia == null)
            {
                return NotFound();
            }
            return Ok(tacGia);
        }

        // POST api/tacgia
        [HttpPost]
        public async Task<ActionResult> AddTacGia([FromBody] TacGia tacGia)
        {
            tacGia.Id = Guid.NewGuid();
            await _tacGiaService.AddTacGiaAsync(tacGia);
            return CreatedAtAction(nameof(GetTacGiaById), new { id = tacGia.Id }, tacGia);
        }

        // PUT api/tacgia/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTacGia(Guid id, [FromBody] TacGia tacGia)
        {
            if (id != tacGia.Id)
            {
                return BadRequest("ID in URL does not match ID in body.");
            }

            try
            {
                await _tacGiaService.UpdateTacGiaAsync(tacGia);
                return NoContent();  // Trả về HTTP 204 nếu cập nhật thành công
            }
            catch (KeyNotFoundException)
            {
                return NotFound();  // Nếu không tìm thấy, trả về HTTP 404
            }
        }

        // DELETE api/tacgia/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTacGia(Guid id)
        {
            await _tacGiaService.DeleteTacGiaAsync(id);
            return NoContent();  // Trả về HTTP 204 khi xóa thành công
        }
    }


}
