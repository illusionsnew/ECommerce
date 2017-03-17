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
                dataBase.Products.Add(new Product { Name = "FF200", Description = "Alternator", Quantity = 100 });
                dataBase.Products.Add(new Product { Name = "LF300", Description = "Wiper", Quantity = 120 });
                dataBase.SaveChanges();
            }
        }
    }
}
