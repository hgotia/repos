using Microsoft.VisualStudio.TestTools.UnitTesting;
using wordInWord;

namespace wordInWordTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Filter_StringContains_1()
        {
            Assert.AreEqual(true, SearchWord.WordSearch("Fox", "The Fox"));
        }
        [TestMethod]
        public void Filter_StringContains_2()
        {
            Assert.AreEqual(true, SearchWord.WordSearch("Fox", "The fox"));
        }
        [TestMethod]
        public void Filter_StringContains_3()
        {
            Assert.AreEqual(true, SearchWord.WordSearch("fox", "The Fox ran away."));
        }
        [TestMethod]
        public void Filter_StringContains_4()
        {
            Assert.AreEqual(false, SearchWord.WordSearch("Fox", "Foxtrot"));
        }
        [TestMethod]
        public void Filter_StringContains_5()
        {
            Assert.AreEqual(false, SearchWord.WordSearch("Fox", ""));
        }
        [TestMethod]
        public void Filter_StringContains_6()
        {
            Assert.AreEqual(false, SearchWord.WordSearch("", "The Fox"));
        }
        [TestMethod]
        public void Filter_StringContains_7()
        {
            Assert.AreEqual(false, SearchWord.WordSearch("Fox", "Fo"));
        }
        [TestMethod]
        public void Filter_StringContains_8()
        {
            Assert.AreEqual(false, SearchWord.WordSearch("Odyn", "Od yn son"));
        }
        [TestMethod]
        public void Filter_StringContains_9()
        {
            Assert.AreEqual(true, SearchWord.WordSearch("I hate SQL", "I hate SQL very much"));
        }
        [TestMethod]
        public void Filter_StringContains_10()
        {
            Assert.AreEqual(true, SearchWord.WordSearch("Shut up", "Brandon please shut up"));
        }
    }
}
