using Microsoft.VisualStudio.TestTools.UnitTesting;
using CamelCase;

namespace CamelCaseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CamemlCase_youWinSome()
        {
            Assert.AreEqual("youWinSome", StringMethods.CamelCase("You win some"));
        }

        [TestMethod]
        public void CamemlCase_quickbrownfox()
        {
            Assert.AreEqual("theCatInTheHat", StringMethods.CamelCase("The Cat In The Hat"));
            Assert.AreEqual("theQuickBrownFoxJumpsOverTheLazyDog", StringMethods.CamelCase("the quick brown fox jumps over the lazy dog"));
        }

        [TestMethod]
        public void CamemlCase_OneWord()
        {
            Assert.AreEqual("one", StringMethods.CamelCase("One"));
        }

        [TestMethod]
        public void PascalCase_youWinSome()
        {
            Assert.AreEqual("YouWinSome", StringMethods.PascalCase("You win some"));
        }

        [TestMethod]
        public void PascalCase_quickbrownfox()
        {
            Assert.AreEqual("TheQuickBrownFoxJumpsOverTheLazyDog", StringMethods.PascalCase("the quick brown fox jumps over the lazy dog")); ;
        }

        [TestMethod]
        public void PascalCase_OneWord()
        {
            Assert.AreEqual("One", StringMethods.PascalCase("one")); ;
        }
    }
}
