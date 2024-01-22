using ABC.bl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void ProductDownload()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expectation = new Product(2)
            {
                ProductName = "Klocki",
                Description = "Kolcki hamulcowe dla dzieci powyżej 2 lat",
                OrderPrice = 199.99M
            };
            // ACt
            var actual = productRepository.Download(2);
            // Assert
            // Assert.AreEqual(actual, expectation);   
            Assert.AreEqual(actual.ProductID, expectation.ProductID);
            Assert.AreEqual(actual.ProductName, expectation.ProductName);
            Assert.AreEqual(actual.Description, expectation.Description);
            Assert.AreEqual(actual.OrderPrice, expectation.OrderPrice);

        }
    }
}
