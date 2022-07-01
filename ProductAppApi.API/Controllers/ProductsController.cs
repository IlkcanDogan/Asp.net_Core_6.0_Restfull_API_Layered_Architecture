using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAppApi.Business.Abstract;
using ProductAppApi.Business.Concreate;
using ProductAppApi.Entities;

namespace ProductAppApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController()
        {
            _productService = new ProductManager();
        }

        [HttpGet("{sBarkod}")]
        public Product Get(string sBarkod)
        {
            return _productService.GetProductByBarcode(sBarkod);
        }
    }
}
