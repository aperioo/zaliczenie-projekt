using ABC.bl;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedElements = new List<ILogging>();

            var client = new Client(1)
            {
                EmailAdress = "admin@admin.com",
                Firstname = "Jonasz",
                Lastname = "Korwin-mekka",
                AdresList = null
            };
            changedElements.Add(client as ILogging);

            var produck = new Product(2)
            {
                ProductName = "Klocki",
                Description = "Description",
                OrderPrice = 120M
            };
            changedElements.Add(produck as ILogging);

            var order = new Order(3)
            {
                OrderDate = DateTime.Now,
            };
            changedElements.Add(order as ILogging);

            LoginService.WriteToFile(changedElements);
        }
    }
}
