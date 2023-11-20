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
        private readonly BlogContext _blogContext;

        public CategoriesController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        [HttpGet("GetAllCategories")]
        public async Task<ActionResult> GetCategories()
        {
            var topic = await _blogContext.CategorieZ.ToListAsync();
            return Ok(topic);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCateId(int id)
        {
            var getCateId = _blogContext.CategorieZ.FindAsync(id);
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

                await _blogContext.AddAsync(addCate);
                await _blogContext.SaveChangesAsync();

                return Ok(addCate);
            } catch
            {
                return BadRequest("Ko thêm được chủ đề");
            }
        }
    }
}
