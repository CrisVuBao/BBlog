using BBlogApi.Data;
using BBlogApi.DTOs;
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
        public async Task<ActionResult<Categories>> AddCategory(CategoryDto categoriesDto)
        {
            try
            {
                var addCate = new Categories
                {
                    CategoryName = categoriesDto.CategoryName
                };

                await _db.AddAsync(addCate);
                await _db.SaveChangesAsync();

                return Ok(addCate);
            } catch
            {
                return BadRequest("Ko thêm được chủ đề");
            }
        }

        [HttpPut("UpdateCategory")]
        public async Task<ActionResult> UpdateCategory(int id, Categories categories)
        {
            var getCategory = await _db.CategorieZ.FindAsync(id);

            getCategory.CategoryName = categories.CategoryName;

            _db.Update(getCategory);
           await _db.SaveChangesAsync();

            return Ok(getCategory);
        }

        [HttpDelete("DeleteCategory")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            var deleteCate = await _db.CategorieZ.FindAsync(id);

            _db.Remove(deleteCate);
            await _db.SaveChangesAsync();

            return Ok("Đã xóa chủ đề");
        }
    }
}
