using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alphabetize;

namespace AlphabetizeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_dog()
        {
            Assert.AreEqual("Dgo", Sorts.StringSort("Dog"));
        }

        [TestMethod]
        public void TestMethod_cat()
        {
            Assert.AreEqual("act", Sorts.StringSort("cat"));
        }

        [TestMethod]
        public void TestMethod_ANDREW()
        {
            Assert.AreEqual("ADENRW", Sorts.StringSort("ANDREW"));
        }

        [TestMethod]
        public void TestMethod_MSSA()
        {
            Assert.AreEqual("AMSS", Sorts.StringSort("MSSA"));
        }

        [TestMethod]
        public void TestMethod_CatInTheHat()
        {
            Assert.AreEqual("aaCeHhInTtt", Sorts.StringSort("CatInTheHat"));
        }
    }
}
