using Microsoft.VisualStudio.TestTools.UnitTesting;
using SellerStorage.Service;

namespace UnitTests.NumbersTests
{
    [TestClass]
    public class NumberServiceUnitTests
    {
        [TestMethod]
        public void TryParseToNumberOrReturnZero_IsNumber_ReturnsNumber()
        {
            var numberService = new NumberService();
            int expectedNumber = 10;

            int result = numberService.TryParseToNumberOrReturnZero("10");

            Assert.AreEqual(expectedNumber, result);
        }

        [TestMethod]
        public void TryParseToNumberOrReturnZero_IsNotNumber_ReturnsZero()
        {
            var numberService = new NumberService();
            int expectedNumber = 0;

            int result = numberService.TryParseToNumberOrReturnZero("Not number");

            Assert.AreEqual(expectedNumber, result);
        }
    }
}
