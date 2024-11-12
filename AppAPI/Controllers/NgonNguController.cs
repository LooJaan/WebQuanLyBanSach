using AppData.Services;
using AppData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NgonNguController : ControllerBase
    {
        private readonly INgonNguService _ngonNguService;

        public NgonNguController(INgonNguService ngonNguService)
        {
            _ngonNguService = ngonNguService;
        }

        [HttpGet]
        public async Task<ActionResult<List<NgonNgu>>> GetAllNgonNgus()
        {
            var ngonNgus = await _ngonNguService.GetAllNgonNgusAsync();
            return Ok(ngonNgus);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NgonNgu>> GetNgonNguById(Guid id)
        {
            var ngonNgu = await _ngonNguService.GetNgonNguByIdAsync(id);
            if (ngonNgu == null)
            {
                return NotFound();
            }
            return Ok(ngonNgu);
        }

        [HttpPost]
        public async Task<ActionResult> AddNgonNgu(NgonNgu ngonNgu)
        {
            ngonNgu.Id = Guid.NewGuid();
            await _ngonNguService.AddNgonNguAsync(ngonNgu);
            return CreatedAtAction(nameof(GetNgonNguById), new { id = ngonNgu.Id }, ngonNgu);
        }

        //[HttpPut("{id}")]
        //public async Task<ActionResult> UpdateNgonNgu(Guid id, NgonNgu ngonNgu)
        //{
        //    if (id != ngonNgu.Id)
        //    {
        //        return BadRequest();
        //    }
        //    await _ngonNguService.UpdateNgonNguAsync(ngonNgu);
        //    return NoContent();
        //}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateNgonNgu(Guid id, [FromBody] NgonNgu ngonNgu)
        {
            // Gọi service để cập nhật đối tượng
            try
            {
                await _ngonNguService.UpdateNgonNguAsync(ngonNgu);
                return NoContent();  // Trả về HTTP 204 nếu cập nhật thành công
            }
            catch (KeyNotFoundException)
            {
                return NotFound();  // Nếu không tìm thấy đối tượng, trả về HTTP 404
            }
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNgonNgu(Guid id)
        {
            await _ngonNguService.DeleteNgonNguAsync(id);
            return NoContent();
        }
    }

}
