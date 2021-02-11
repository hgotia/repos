using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primes;

namespace PrimesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrime_8()
        {
            Assert.AreEqual(false, CheckPrime.IsPrime(8));
        }

        [TestMethod]
        public void TestPrime_9()
        {
            Assert.AreEqual(false, CheckPrime.IsPrime(9));
        }

        [TestMethod]
        public void TestPrime_11()
        {
            Assert.AreEqual(true, CheckPrime.IsPrime(11));
        }

        [TestMethod]
        public void TestPrime_17()
        {
            Assert.AreEqual(true, CheckPrime.IsPrime(17));
        }

        [TestMethod]
        public void SumPrime_17()
        {
            Assert.AreEqual(58, AggregatePrime.SumPrime(17));
        }

        [TestMethod]
        public void SumPrime_100()
        {
            Assert.AreEqual(1060, AggregatePrime.SumPrime(100));
        }

        [TestMethod]
        public void SumPrime_77()
        {
            Assert.AreEqual(712, AggregatePrime.SumPrime(77));
        }

        [TestMethod]
        public void SumPrime_neg1()
        {
            Assert.AreEqual(0, AggregatePrime.SumPrime(-1));
        }
    }
}
