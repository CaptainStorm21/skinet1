using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController: ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "this is the list of the products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "this is a single product";
        }
    }
}