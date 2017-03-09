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
        private readonly Mock<ICatalogServices> moqCatalogServices;

        public ProductControllerTest()
        {
            moqCatalogServices = new Mock<ICatalogServices>();                   
        }

        [Fact]
        public void GivenCatalogServiceReturnProducts_WhenGetAllExecutes_ReturnsSameListOfProducts()
        {
            var productList = new List<Product>();
            var product1 = new Product { Id = 1, Name = "Battery" };
            var product2 = new Product { Id = 2, Name = "Wiper" };
            productList.Add(product1);
            productList.Add(product2);
            moqCatalogServices.
                Setup(cs => cs.GetProducts()).
                Returns(() => productList);
            var productController = new ProductController(moqCatalogServices.Object);
            var result = productController.GetAll();
            Assert.Equal(productList, result);
        }

        [Fact]
        public void GivenProductName_WhenFindProductByNameExecutes_ReturnsProduct()
        {
            var product = new Product { Id = 1, Name = "FF200", Description ="Battery" };                     
            moqCatalogServices
                .Setup(cs => cs.FindProductByName(It.IsAny<string>()))
                .Returns(product);
            var productController = new ProductController(moqCatalogServices.Object);
            var result = productController.GetProductByName("LF3000");
            Assert.Equal(product, result);
        }

        [Fact]
        public void GivenProductId_WhenFindProductByIdExecutes_ReturnsProduct()
        {
            const int productId = 1;
            var product = new Product { Id = productId, Name = "FF200", Description = "Battery" };             
            moqCatalogServices.
                Setup(cs => cs.FindProductById(productId)).
                Returns(product);
            var productController = new ProductController(moqCatalogServices.Object);
            var result = productController.GetProductById(productId);
            Assert.Equal(product, result);
        }
    }
}
