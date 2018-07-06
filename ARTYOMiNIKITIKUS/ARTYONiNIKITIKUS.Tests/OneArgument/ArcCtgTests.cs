using ARTYOMiNIKITIKUS.OneArgument;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.OneArgument
{
    [TestFixture]
    public class ArcCtgTests
    {
        [TestCase(1, 1.2732)]
        [TestCase(2, 0.9032)]
        [TestCase(3, 0.8006)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcCtg();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}