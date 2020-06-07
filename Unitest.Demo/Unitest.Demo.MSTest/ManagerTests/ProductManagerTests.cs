using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Unitest.Business;
using Unitest.Business.Exception;
using Unitest.Data;

namespace Unitest.Demo.MSTest.ManagerTests
{
    [TestClass]
    public class ProductManagerTests
    {
        [TestMethod, ExpectedException(typeof(ProductAlreadyExist))]
        public void Given_with_a_user_When_a_product_create_with_existing_name__Then_it_throws_exception()
        {

            Mock<IProductDal> mockProductDal = new Mock<IProductDal>();
            mockProductDal.Setup(mpd => mpd.Get(It.IsAny<string>())).Returns(new Product());

            var productManager = new ProductManager(mockProductDal.Object);

            productManager.InsertProduct(new Product()
            {
                ProductId = 1,
                ProductName = "Test Product"
            });

        }
    }
}
