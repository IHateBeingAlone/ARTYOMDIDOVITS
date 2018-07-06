using System;
using ARTYOMiNIKITIKUS.TwoArguments;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.TwoArguments
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(16, 2, 8)]
        [TestCase(30, 6, 5)]
        [TestCase(33, 6, 5.5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Division");
            double result = calculator.Calculate(26, 13);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Division");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }
}