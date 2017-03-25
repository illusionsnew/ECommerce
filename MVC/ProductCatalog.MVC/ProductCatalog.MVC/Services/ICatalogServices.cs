using ProductCatalog.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.MVC.Services
{
    public interface ICatalogServices
    {
        IEnumerable<Product> GetProducts();
        Product FindProductByIdOrName(string productIdorName);
    }
}
