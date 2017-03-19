using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.DA
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dataBase = new CatlogDB())
            {
                dataBase.Products.Add(new Product { Name = "FF202", Description = "Alternator1", Quantity = 300 });
                dataBase.Products.Add(new Product { Name = "LF303", Description = "Wiper1", Quantity = 220 });
                dataBase.Products.Add(new Product { Name = "LF305", Description = "Wiper2", Quantity = 260 });
                dataBase.SaveChanges();
            }
        }
    }
}
