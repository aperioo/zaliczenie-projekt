using ABC.bl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ABC.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void OrderDownload()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expectation = new Order(3)
            {
                OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };
            // Act
            var actual = orderRepository.Download(3);
            // Assert
            // Assert.AreEqual(actual, expectation);   
            Assert.AreEqual(expectation.OrderID, actual.OrderID);
            Assert.AreEqual(expectation.OrderDate, actual.OrderDate);

        }
        [TestMethod]
        public void OrderDownloadDisplayTest()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expectation = new OrderDisplay()
            {
                Firstname = "Marcin",
                Lastname = "Kwak",
                OrderDate = new DateTimeOffset(2024, 1, 1, 1, 17, 15, 3, new TimeSpan(7, 0, 0)),
                OrderAdres = new Adres()
                {
                    AdresType = 1,
                    Street = "Kosmiczna",
                    City = "Glogau",
                    PostalCode = "40-452",
                    Country = "Poland"
                },
                OrderStatusDisplayList = new List<OrderStatusDisplay>()
                {
                     new OrderStatusDisplay()
                     {
                       ProductName = "Szczotka",
                       OrderQuantity = 4,
                       OrderPrice = 119.77M
                    },
                     new OrderStatusDisplay() {
                    ProductName = "Miotła",
                    OrderQuantity = 7,
                    OrderPrice = 249M
                }
                }
        };
            // Act
            var actual = orderRepository.DownloadOrderDisplay(10);
            // Assert
            // Assert.AreEqual(actual, expectation);   
            Assert.AreEqual(expectation.OrderID, actual.OrderID);
            Assert.AreEqual(expectation.OrderDate, actual.OrderDate);
            Assert.AreEqual(expectation.Firstname, actual.Firstname);
            Assert.AreEqual(expectation.Lastname, actual.Lastname);
            Assert.AreEqual(expectation.OrderAdres.AdresType, actual.OrderAdres.AdresType);
            Assert.AreEqual(expectation.OrderAdres.Street, actual.OrderAdres.Street);
            Assert.AreEqual(expectation.OrderAdres.City, actual.OrderAdres.City);
            Assert.AreEqual(expectation.OrderAdres.PostalCode, actual.OrderAdres.PostalCode);
            Assert.AreEqual(expectation.OrderAdres.Country, actual.OrderAdres.Country);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expectation.OrderStatusDisplayList[i].ProductName, actual.OrderStatusDisplayList[i].ProductName);
                Assert.AreEqual(expectation.OrderStatusDisplayList[i].OrderQuantity, actual.OrderStatusDisplayList[i].OrderQuantity);
                Assert.AreEqual(expectation.OrderStatusDisplayList[i].OrderPrice, actual.OrderStatusDisplayList[i].OrderPrice);
            }
        }
    }
}
 