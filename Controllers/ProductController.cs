using Microsoft.AspNetCore.Mvc;
using WebService.Models;
using WebService.Services.Interfaces;

namespace WebService.Controllers {
    
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController: ControllerBase {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) {
            _productService = productService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> All() {
            var products = await _productService.All();
            if (products != null) {
                return Ok(products);
            } else {
                return NotFound();
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int Id) {
            var product = await _productService.Get(Id);

            if(product != null) {
                return Ok(product);
            } else {
                return NotFound();
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] Product product) {
            if(product.isValid()) {
                var p = await _productService.Create(product);
                return Ok(p); 
            } else {
                return BadRequest();
            }
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] Product product) {
            if(product.Id > 0) {
                bool updated = await _productService.Update(product);
                if(updated) {
                    return Ok(await _productService.Get(product.Id));
                } else {
                    return BadRequest(await _productService.Get(product.Id));
                }
            } else {
                return BadRequest(product);
            }
        }
    }
}