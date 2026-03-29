using iakademi_WEBAPI_PUBLISH.Models.MVVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iakademi_WEBAPI_PUBLISH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        iakademiContext context = new iakademiContext();

        [HttpGet(Name ="GetProduct")]
        public IEnumerable<Product> Get()
        {
            return context.Products.ToList();
        }
    }
}
