using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ABC.bl;
namespace ABC.BLTest
{
    [TestClass]
    public class AppTest
    {
        [TestMethod]
        public void FirstnameLastnameTest()
        {
            //Arrange
            Client client = new Client();
            client.Firstname = "Janusz";
            client.Lastname = "Korwin-Mikke";
            string fullname = "Janusz Korwin-Mikke";

            //Act

            string actual = client.FirstnameLastname;

            //Assert

            Assert.AreEqual(fullname, actual);
        }
        [TestMethod]
        public void FirstnameLastnameEmptyfn()
        {
            //Arrange
            Client client = new Client();
            client.Lastname = "Korwin-Mikke";
            string fullname = "Korwin-Mikke";

            //Act

            string actual = client.FirstnameLastname;

            //Assert

            Assert.AreEqual(fullname, actual);
        }
        [TestMethod]
        public void FirstnameLastnameEmptyln()
        {
            //Arrange
            Client client = new Client();
            client.Firstname = "Janusz";
            string fullname = "Janusz";

            //Act

            string actual = client.FirstnameLastname;

            //Assert

            Assert.AreEqual(fullname, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            Client client1 = new Client();
            client1.Firstname = "Janusz";
            Client.Counter += 1;

            Client client2 = new Client();
            client2.Firstname = "Marek";
            Client.Counter += 1;

            Client client3 = new Client();
            client3.Firstname = "Seba";
            Client.Counter += 1;

            //Assert
            Assert.AreEqual(3, Client.Counter);
        }
        [TestMethod]
        public void ValidateTest()
        {
        //Arrange
        var client = new Client();
            client.Lastname = "Górczyński";
            client.EmailAdress = "gorczynski@gmail.com";
            var expectation = true;
        //ACT
        var actual = client.Validate();
        //Assert
        Assert.AreEqual(expectation, actual);
        }
        [TestMethod]
        public void ValidateTestNoLastname()
        {
            //Arrange
            var client = new Client();
            client.EmailAdress = "gorczynski@gmail.com";
            var expectation = false;

            var client1 = new Client(191);
            var client2 = new Client();
            //ACT
            var actual = client.Validate();
            //Assert
            Assert.AreEqual(expectation, actual);
        }
        [TestMethod]
        public void ValidateTestProductName()
        {
            //Arrange
            var product = new Product();
            product.ProductName = "Test";
            var expectation = true;

            //ACT
            var actual = product.Validate();
            //Assert
            Assert.AreEqual(expectation, actual);
        }
        public void ValidateTestProductNoName()
        {
            //Arrange
            var product = new Product();
            var expectation = false;

            //ACT
            var actual = product.Validate();
            //Assert
            Assert.AreEqual(expectation, actual);
        }
    }
}
