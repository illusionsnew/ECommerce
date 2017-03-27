using System;
using System.Collections.Generic;
using System.IO;
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
                dataBase.Products.Add(new Product { Name = "ABC", Description = "1Alternator21", Quantity = 1300, ProductImage=ReadImageFile("C:\\Users\\SAJITH GS\\Downloads\\Sajith_W_Background.jpg") });
                dataBase.Products.Add(new Product { Name = "DEF", Description = "2Wiper22", Quantity = 1260, ProductImage = ReadImageFile("C:\\Users\\SAJITH GS\\Downloads\\Sajith_W_Background.jpg") });
                dataBase.SaveChanges();
            }


        }

        public static byte[] ReadImageFile(string imageLocation)
        {
            byte[] imageData = null;
            FileInfo fileInfo = new FileInfo(imageLocation);
            long imageFileLength = fileInfo.Length;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imageData = br.ReadBytes((int)imageFileLength);
            return imageData;
        }

    }
}
