using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ProductCatalog.API.Controllers;
using Moq;
using ProductCatalog.API.Services;
using ProductCatalog.API.Model;

namespace ProductCatalog.Test.Controllers
{
    public class ProductControllerTest
    {
        [Fact]
        public void GivenCatalogServiceReturnProducts_WhenGetAllExecutes_ReturnsSameListOfProducts()
        {
            var moqCatalogServices = new Mock<ICatalogServices>();
            var productList = new List<Product>();
            var product1 = new Product { Id = 1, Name = "Battery" };
            var product2 = new Product { Id = 2, Name = "Battery" };
            productList.Add(product1);
            productList.Add(product2);
            moqCatalogServices.
                Setup(cs => cs.GetProducts()).
                Returns(() => productList);
            var productController = new ProductController(moqCatalogServices.Object);
            var result = productController.GetAll();
            Assert.Equal(productList, result);
        }
    }
}
