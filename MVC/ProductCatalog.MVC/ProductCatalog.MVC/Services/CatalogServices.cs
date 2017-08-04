using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCatalog.MVC.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ProductCatalog.MVC.Services
{
    public class CatalogServices : ICatalogServices
    {
        Helper helper = new Helper();

        public string CreateNewProduct(Product p)
        {
            return helper.CreateNewProduct(p);
        }

        public string DeleteProduct(int id)
        {
            return helper.DeleteProduct(id);
        }

        public Product FindProductByIdOrName(string productName)
        {
            return helper.GetProductData(productName);
        }

        public IEnumerable<Product> GetProducts()
        {
            return helper.GetProducts();
        }

    }
}
