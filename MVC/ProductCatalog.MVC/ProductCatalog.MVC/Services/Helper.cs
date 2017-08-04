using Newtonsoft.Json;
using ProductCatalog.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ProductCatalog.MVC.Services
{
    public class Helper
    {
        private string resposeJson = string.Empty;
        private string baseURL = "http://localhost:56990";

        public IEnumerable<Product> GetProducts()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var apiRespose = client.GetAsync("api/product/").Result;
                if (apiRespose.IsSuccessStatusCode)
                {
                    resposeJson = apiRespose.Content.ReadAsStringAsync().Result;
                }
            }
            return(JsonConvert.DeserializeObject<List<Product>>(resposeJson));
        }

        public Product GetProductData(string productIdorName)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var apiRespose = client.GetAsync("api/product/" + productIdorName).Result;
                if (apiRespose.IsSuccessStatusCode)
                {
                    resposeJson = apiRespose.Content.ReadAsStringAsync().Result;
                }
            }
            return JsonConvert.DeserializeObject<Product>(resposeJson);
        }

        public string DeleteProduct(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));                
                var apiRespose = client.DeleteAsync("api/product/" + id).Result;
                if (apiRespose.IsSuccessStatusCode)
                {
                    resposeJson = apiRespose.Content.ReadAsStringAsync().Result;
                }
            }

            return resposeJson;
        }

        public string CreateNewProduct(Product p)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                //client.PostAsync<Product>("api/product", p).ContinueWith(())
                
            }
            return "Product Added Successfully";
        }
    }
}
