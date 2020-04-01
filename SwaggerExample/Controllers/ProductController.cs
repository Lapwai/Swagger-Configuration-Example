using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetResponse")]
        public ActionResult GetResponse()
        {
            return Ok("Return Success");
        }
        [HttpGet("GetAllProduct")]




        public IEnumerable<Product> GetAllProduct()
        {
            var proList = new List<Product>(){
                new Product() { ProductId=1, ProductName="Oneplus 7T Pro", Price=1299},
                new Product() { ProductId=2, ProductName="iPhone XR", Price=1499},
                new Product() { ProductId=3, ProductName="Samsung Note 10 Plus", Price=1399},
                new Product() { ProductId=4, ProductName="Xiaomi 10 Pro", Price=1199},
                new Product() { ProductId=5, ProductName="Huawei P40 Pro", Price=1599},
                new Product() { ProductId=6, ProductName="Mac Mini Intel i7(Gen 8) 16G", Price=2399},
                new Product() { ProductId=7, ProductName="iPad Pro 2020(Gen 4) 256GB", Price=1799}
            };
            return proList;
        }
        [HttpPost("PostProduct")]
        public IEnumerable<Product> SaveProduct(Product obj)
        {
            var proList = new List<Product>(){
                new Product() { ProductId=1, ProductName="Oneplus 7T Pro", Price=1299},
                new Product() { ProductId=2, ProductName="iPhone XR", Price=1499},
                new Product() { ProductId=3, ProductName="Samsung Note 10 Plus", Price=1399},
                new Product() { ProductId=4, ProductName="Xiaomi 10 Pro", Price=1199},
                new Product() { ProductId=5, ProductName="Huawei P40 Pro", Price=1599},
                new Product() { ProductId=6, ProductName="Mac Mini Intel i7(Gen 8) 16G", Price=2399},
                new Product() { ProductId=7, ProductName="iPad Pro 2020(Gen 4) 256GB", Price=1799}
            };
            proList.Add(obj);
            return proList;
        }



        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
        }



    } 
}