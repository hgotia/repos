using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static CeasarCipher.CeasarCipher;

namespace CeasarTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EncryptionTest_1()
        {
            Assert.AreEqual("JCRRA", CharShift("Happy", 2));
        }

        public void EncryptionTest_Reverse()
        {
            int key = 3;
            string PlainText = "The quick brown fox jumps over the lazy dogs";
            string CipherText = CharShift(PlainText, key);

            Console.WriteLine(PlainText);
            Console.WriteLine(CipherText);
            Console.WriteLine(CharShift(CipherText, -key));
            Console.WriteLine(PlainText.ToUpper());

            Assert.AreEqual(PlainText.ToUpper(), CharShift(CipherText, -key));
        }
    }
}
