using iakademi_WEBAPI_PUBLISH.Models.MVVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iakademi_WEBAPI_PUBLISH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        iakademiContext context = new iakademiContext();

        [HttpGet(Name = "GetCategory")]
        public IEnumerable<Category> Get()
        {
            return context.Categories.ToList();
        }

        [HttpGet("{id}", Name = "GetCategoryById")]
        public Category? Get(int id)
        {
            return context.Categories.FirstOrDefault(c => c.CategoryID == id);
        }

    }
}
