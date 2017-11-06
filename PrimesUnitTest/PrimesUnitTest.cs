using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleWpfApp.Model;

namespace PrimesUnitTest
{
    [TestClass]
    public class PrimesUnitTest
    {
        [TestMethod]
        public void TestPrimeWith4()
        {
            var prime = new Prime();
            var list = prime.GeneratePrimes(4);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(2, list[0]);
            Assert.AreEqual(3, list[1]);           
        }
        [TestMethod]
        public void TestPrimeWith16()
        {
            var prime = new Prime();
            var list = prime.GeneratePrimes(16);
            Assert.AreEqual(6, list.Count);
            Assert.AreEqual(2, list[0]);
            Assert.AreEqual(3, list[1]);
            Assert.AreEqual(5, list[2]);
            Assert.AreEqual(7, list[3]);
            Assert.AreEqual(11, list[4]);
            Assert.AreEqual(13, list[5]);
        }
    }
}
