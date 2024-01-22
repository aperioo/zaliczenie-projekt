using ABC.bl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace ABC.BLTest
{
    [TestClass]
    public class ClientRepositoryTest
    {
        [TestMethod]
        public void ClientDownload()
        {
            //Arrange
            var clientRepository = new ClientRepository();
            var expectation = new Client(1)
            {
                EmailAdress = "izraelnieistnieje@gmail.com",
                Firstname = "Jonasz",
                Lastname = "Mekka"
            };
            // ACt
            var actual = clientRepository.Download(1);

            // Assert
            // Assert.AreEqual(actual, expectation);   
            Assert.AreEqual(actual.ClientID, expectation.ClientID);
            Assert.AreEqual(actual.EmailAdress, expectation.EmailAdress);
            Assert.AreEqual(actual.Firstname, expectation.Firstname);
            Assert.AreEqual(actual.Lastname, expectation.Lastname);

        }
        
        [TestMethod]
        public void ClientDownloadWithAdresses()
        {
            //Arrange
            var clientRepository = new ClientRepository();
            var expectation = new Client(1)
            {
                EmailAdress = "izraelnieistnieje@gmail.com",
                Firstname = "Jonasz",
                Lastname = "Mekka",
                AdresList = new List<Adres>()
                {
                    new Adres(1)
            {
                AdresType = 1,
                Street = "Gościnna",
                City = "Katowice",
                PostalCode = "51-164",
                Country = "Polska"
            },
                    new Adres(2)
            {
                AdresType = 1,
                Street = "Kosmiczna",
                City = "Kraków",
                PostalCode = "61-164",
                Country = "Polska"
            }
        }
            };
            // ACt
            var actual = clientRepository.Download(1);

            // Assert
            // Assert.AreEqual(actual, expectation);   
            Assert.AreEqual(actual.ClientID, expectation.ClientID);
            Assert.AreEqual(actual.EmailAdress, expectation.EmailAdress);
            Assert.AreEqual(actual.Firstname, expectation.Firstname);
            Assert.AreEqual(actual.Lastname, expectation.Lastname);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(actual.AdresList[i].AdresType, expectation.AdresList[i].AdresType);
                Assert.AreEqual(actual.AdresList[i].Street, expectation.AdresList[i].Street);
                Assert.AreEqual(actual.AdresList[i].City, expectation.AdresList[i].City);
                Assert.AreEqual(actual.AdresList[i].Country, expectation.AdresList[i].Country);
                Assert.AreEqual(actual.AdresList[i].PostalCode, expectation.AdresList[i].PostalCode);
            }

        }

    }
}
