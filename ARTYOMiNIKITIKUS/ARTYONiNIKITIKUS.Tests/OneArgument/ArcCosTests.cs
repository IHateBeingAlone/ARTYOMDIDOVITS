using System;
using ARTYOMiNIKITIKUS.OneArgument;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.OneArgument
{
    [TestFixture]
    public class ArcCosTests
    {
        [TestCase(0, 1.5708)]
        [TestCase(1, 0.0000)]
        [TestCase(-1, 3.1416)]
        public void CalculateTest(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("ArcCos");
            double actualResult = calculator.Calculate(0.6521);
            Assert.AreEqual(0.8604, actualResult, 0.0001);
        }

        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator("ArcCos");
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}