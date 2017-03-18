using ProductCatalog.DA;
using System.Collections.Generic;
using System.Linq;

namespace ProductCatalog.API.Services
{
    public class CatalogSQLDB
    {
        private readonly CatalogDB catalogDB;

        public CatalogSQLDB()
        {
            catalogDB = new CatalogDB();
        }

        public IEnumerable<Model.Product> Products()
        {
            return AsModelProducts(catalogDB.Products); ;
        }

        private static IEnumerable<Model.Product> AsModelProducts(Microsoft.EntityFrameworkCore.DbSet<Product> dbProducts)
        {
            return dbProducts.Select(product => new Model.Product
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Quantity = product.Quantity
            });
        }
    }
}