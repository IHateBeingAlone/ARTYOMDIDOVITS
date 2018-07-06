using System;
using ARTYOMiNIKITIKUS.OneArgument;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.OneArgument
{
    [TestFixture]
    public class LnXTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.3010)]
        [TestCase(3, 0.4771)]
        public void CalculateTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("LnX");
            double actualResult = calculator.Calculate(4);
            Assert.AreEqual(1.3863, actualResult, 0.0001);
        }

        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("LnX");
            Assert.Throws<Exception>(() => calculator.Calculate(-5));
        }
    }
}