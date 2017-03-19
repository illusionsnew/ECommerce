using ProductCatalog.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.Services
{
    public interface ICatalog
    {
        IEnumerable<Product> GetProducts();
        Product FindProductById(int productId);
        Product FindProductByName(string productName);
    }
}