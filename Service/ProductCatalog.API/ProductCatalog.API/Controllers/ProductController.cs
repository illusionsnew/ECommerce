using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.API.Services;
using ProductCatalog.DA;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductCatalog.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private ICatalog catalogServices;

        public ProductController(ICatalog catalogServices)
        {
            this.catalogServices = catalogServices;
        }
        
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {            
            return catalogServices.GetProducts();
        }
        
        [HttpGet("{id:int}")]
        public Product GetProductById(int id)
        {
            var item = catalogServices.FindProductById(id);
            return item;
        }

        [HttpGet("{name}")]
        public Product GetProductByName(string name)
        {
            var item = catalogServices.FindProductByName(name);
            return item;
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
