using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArraySortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] testArray1 = { 5, 4, 8, 6, 5, 15, 98, 0, 55, -88, 09 };
            int[] testArray2 = { 5, 4, 8, 6, 5, 15, 98, 0, 55, -88, 09 };
            Array.Sort(testArray1);

            Assert.AreEqual(testArray1, ArraySort.BubbleSort.ArraySort(testArray2));
        }
    }
}
