using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCatalog.DA;

namespace ProductCatalog.API.Services
{
    public class Catalog : ICatalog
    {
        private CatalogDB catalogDB;

        public Catalog()
        {
            catalogDB = new CatalogDB();
        }
        public Product FindProductById(int productId)
        {
            return catalogDB.Products.FirstOrDefault(p => p.Id == productId);
        }

        public Product FindProductByName(string productName)
        {
            return catalogDB.Products.FirstOrDefault(p => p.Name == productName);
        }

        public IEnumerable<Product> GetProducts()
        {
            return catalogDB.Products;
        }
    }
}
