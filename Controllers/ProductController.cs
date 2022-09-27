using Microsoft.AspNetCore.Mvc;
using ProductManager.Services;
 
namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
 
        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }
    }
}
