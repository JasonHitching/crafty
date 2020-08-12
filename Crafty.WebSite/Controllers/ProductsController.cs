using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crafty.WebSite.Models;
using Crafty.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crafty.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductService productService { get; }
        public ProductsController(JsonFileProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productService.GetProducts();
        }
    }

}
