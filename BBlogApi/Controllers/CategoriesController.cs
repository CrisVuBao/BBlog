using BBlogApi.Data;
using BBlogApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BBlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly BlogContext _db;

        public CategoriesController(BlogContext blogContext)
        {
            _db= blogContext;
        }

        [HttpGet("GetAllCategories")]
        public async Task<ActionResult> GetCategories()
        {
            var topic = await _db.CategorieZ.ToListAsync();
            return Ok(topic);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCateId(int id)
        {
            var getCateId = await _db.CategorieZ.FindAsync(id);
            await _db.SaveChangesAsync();
            return Ok(getCateId);
        }

        [HttpPost("AddCategory")]
        public async Task<ActionResult> AddCategory(Categories categories)
        {
            try
            {
                var addCate = new Categories
                {
                    CategoryName = categories.CategoryName
                };

                await _db.AddAsync(addCate);
                await _db.SaveChangesAsync();

                return Ok(addCate);
            } catch
            {
                return BadRequest("Ko thêm được chủ đề");
            }
        }
    }
}
