using ARTYOMiNIKITIKUS.OneArgument;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.OneArgument
{
    [TestFixture]
    public class ArcCosTests
    {
        [TestCase(0, 1.5708)]
        [TestCase(1, 0.0000)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcCos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}