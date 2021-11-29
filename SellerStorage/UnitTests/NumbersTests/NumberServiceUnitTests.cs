using Microsoft.VisualStudio.TestTools.UnitTesting;
using SellerStorage.Service;
using SellerStorage.Service.ServiceInterfaceClass;

namespace UnitTests.NumbersTests
{
    [TestClass]
    public class NumberServiceUnitTests
    {
        [TestMethod]
        public void TryParseToNumberOrReturnZero_IsNumber_ReturnsNumber()
        {
            var numberService = new NumberService(new NumberServiceForCultureInfoInvariantCulture());
            int expectedNumber = 10;
            string passingValueAttribute = "10";

            int result = numberService.TryParseToNumberOrReturnZero(passingValueAttribute);

            Assert.AreEqual(expectedNumber, result);
        }

        [TestMethod]
        public void TryParseToNumberOrReturnZero_IsNotNumber_ReturnsZero()
        {
            var numberService = new NumberService(new NumberServiceForCultureInfoInvariantCulture());
            int expectedNumber = 0;
            string passingValueAttribute = "Not number";

            int result = numberService.TryParseToNumberOrReturnZero(passingValueAttribute);

            Assert.AreEqual(expectedNumber, result);
        }

        [TestMethod]
        public void TryParseToDoubleOrReturnZero_IsNumber_ReturnsNumber()
        {
            var numberService = new NumberService(new NumberServiceForCultureInfoInvariantCulture());
            double expectedNumber = 1.1;
            string passingValueAttribute = "1.1";

            double result = numberService.TryParseToDoubleOrReturnZero(passingValueAttribute);

            Assert.AreEqual(expectedNumber, result);
        }

        [TestMethod]
        public void TryParseToDoubleOrReturnZero_IsNumberWhenCommaPassed_ReturnsNumber()
        {
            var numberService = new NumberService(new NumberServiceForCultureInfoInvariantCulture());
            double expectedNumber = 1.1;
            string passingValueAttribute = "1,1";

            double result = numberService.TryParseToDoubleOrReturnZero(passingValueAttribute);

            Assert.AreEqual(expectedNumber, result);
        }

        [TestMethod]
        public void TryParseToDoubleOrReturnZero_IsNotNumber_ReturnsZero()
        {
            var numberService = new NumberService(new NumberServiceForCultureInfoInvariantCulture());
            double expectedNumber = 0;
            string passingValueAttribute = "Not Number";

            double result = numberService.TryParseToDoubleOrReturnZero(passingValueAttribute);

            Assert.AreEqual(expectedNumber, result);
        }

    }
}
