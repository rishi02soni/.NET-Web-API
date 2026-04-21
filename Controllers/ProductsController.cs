using Microsoft.AspNetCore.Mvc;
using BasicDotNetApi.Models;
using BasicDotNetApi.Services;

namespace BasicDotNetApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductsController(ProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _service.GetById(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _service.Add(product);
            return Ok(product);
        }
    }
}
