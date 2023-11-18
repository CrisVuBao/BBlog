using BBlogApi.Data;
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

        [HttpGet("Categories")]
        public async Task<ActionResult> GetCategories()
        {
            var topic = await _blogContext.CategorieZ.ToListAsync();
            return Ok(topic);
        }
    }
}
