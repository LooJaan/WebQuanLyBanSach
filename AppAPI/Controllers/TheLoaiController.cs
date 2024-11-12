using AppData;
using AppData.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 
    public class TheLoaiController : ControllerBase
    {
        private readonly ITheLoaiService _theLoaiService;

        public TheLoaiController(ITheLoaiService theLoaiService)
        {
            _theLoaiService = theLoaiService;
        }

        // GET api/theloai
        [HttpGet]
        public async Task<ActionResult<List<TheLoai>>> GetAllTheLoais()
        {
            var theLoais = await _theLoaiService.GetAllTheLoaisAsync();
            return Ok(theLoais);
        }

        // GET api/theloai/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TheLoai>> GetTheLoaiById(Guid id)
        {
            var theLoai = await _theLoaiService.GetTheLoaiByIdAsync(id);
            if (theLoai == null)
            {
                return NotFound();
            }
            return Ok(theLoai);
        }

        // POST api/theloai
        [HttpPost]
        public async Task<ActionResult> AddTheLoai([FromBody] TheLoai theLoai)
        {
            theLoai.Id = Guid.NewGuid();
            await _theLoaiService.AddTheLoaiAsync(theLoai);
            return CreatedAtAction(nameof(GetTheLoaiById), new { id = theLoai.Id }, theLoai);
        }

        // PUT api/theloai/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTheLoai(Guid id, [FromBody] TheLoai theLoai)
        {
            if (id != theLoai.Id)
            {
                return BadRequest();
            }

            try
            {
                await _theLoaiService.UpdateTheLoaiAsync(theLoai);
                return NoContent();  // Trả về HTTP 204 nếu cập nhật thành công
            }
            catch (KeyNotFoundException)
            {
                return NotFound();  // Nếu không tìm thấy, trả về HTTP 404
            }
        }

        // DELETE api/theloai/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTheLoai(Guid id)
        {
            await _theLoaiService.DeleteTheLoaiAsync(id);
            return NoContent();  // Trả về HTTP 204 khi xóa thành công
        }
    }

}
