using System;
using ARTYOMiNIKITIKUS.OneArgument;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.OneArgument
{
    [TestFixture]
    public class ArcSinTests
    {
        [TestCase(1, 1.5708)]
        [TestCase(0, 0.0000)]
        [TestCase(-1, -1.5708)]
        public void CalculateTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("ArcSin");
            double actualResult = calculator.Calculate(0.6521);
            Assert.AreEqual(0.7104, actualResult, 0.0001);
        }

        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("ArcSin");
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}