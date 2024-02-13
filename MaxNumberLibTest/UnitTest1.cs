using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxNumberLib;

namespace MaxNumberLibTests
{
    [TestClass]
    public class MaxNumberFinderTests
    {
        [TestMethod]
        public void TestMaxOfTwoIntegers()
        {
            int result = MaxNumberFinder.Max(5, 10);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMaxOfTwoFloats()
        {
            float result = MaxNumberFinder.Max(3.5f, 7.2f);
            Assert.AreEqual(7.2f, result);
        }

        [TestMethod]
        public void TestMaxOfTwoDoubles()
        {
            double result = MaxNumberFinder.Max(10.5, 8.7);
            Assert.AreEqual(10.5, result);
        }

        [TestMethod]
        public void TestMaxOfThreeIntegers()
        {
            int result = MaxNumberFinder.Max(15, 8, 20);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestMaxOfThreeDoubles()
        {
            double result = MaxNumberFinder.Max(5.6, 8.9, 3.2);
            Assert.AreEqual(8.9, result);
        }
    }
}
