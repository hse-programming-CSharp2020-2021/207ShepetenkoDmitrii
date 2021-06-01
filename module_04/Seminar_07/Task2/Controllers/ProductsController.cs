using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Services;

namespace Task2.Controllers
{
    public class ProductsController : Controller
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IActionResult Index()
        {
            return View(ProductService.GetProducts());
        }

        [Route("product/{id}")]
        public IActionResult Product(string id) =>
        View("ViewItem", ProductService.GetProducts().First(x => x.Id == id));

    }

}
