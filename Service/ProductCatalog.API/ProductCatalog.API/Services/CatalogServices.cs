using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCatalog.API.Model;
using System.Xml.Linq;

namespace ProductCatalog.API.Services
{
    public class CatalogServices : ICatalogServices
    {
        private readonly List<Product> products;
       
        public CatalogServices()
        {
            products = new List<Product>();
            var product1 = new Product { Id = 1, Name = "FF200", Description = "Battery", Quantity = 12 };
            var product2 = new Product { Id = 2, Name = "FF204", Description = "Wiper", Quantity = 10 };
            
            products.Add(product1);
            products.Add(product2);
        }
        public Product FindProductById(int productId)
        {
            return products.FirstOrDefault(p => p.Id == productId);
        }

        public Product FindProductByName(string productName)
        {            
            return products.FirstOrDefault(p => p.Name == productName);
            
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
