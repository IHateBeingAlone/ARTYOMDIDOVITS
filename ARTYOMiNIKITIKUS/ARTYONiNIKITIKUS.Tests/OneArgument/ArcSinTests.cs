using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYOMiNIKITIKUS.Tests.OneArguments
{
    [TestFixture]
    public class ArcSinTests
    {
        [TestCase(1, 1.5708)]
        [TestCase(0, 0.0000)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcSin();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}