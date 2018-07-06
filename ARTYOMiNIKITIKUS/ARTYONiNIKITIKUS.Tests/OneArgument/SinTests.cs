using ARTYOMiNIKITIKUS.OneArgument;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.OneArgument
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.8415)]
        [TestCase(7, 0.6570)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Sin();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}