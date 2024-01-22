using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CommonTest
{
    [TestClass]
    public class StringServiceTest
    {
        [TestMethod]
        public void InsertSpaceTest()
        {
            var source = "KlockiLego";
            var expectation = "Klocki Lego";

            var actual = source.InsertSpace();
            Assert.AreEqual(expectation, actual);
        }
        [TestMethod]
        public void InsertSpaceTest2()
        {
            var source = "Klocki Lego";
            var expectation = "Klocki Lego";

            var actual = source.InsertSpace();

            Assert.AreEqual(expectation, actual);
        }
    }
}
