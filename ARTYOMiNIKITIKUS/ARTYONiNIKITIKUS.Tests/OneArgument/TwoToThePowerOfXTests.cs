using ARTYOMiNIKITIKUS.OneArgument;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.OneArgument
{
    [TestFixture]
    public class TwoToThePowerOfXTests
    {
        [TestCase(2, 4)]
        [TestCase(3, 8)]
        [TestCase(4, 16)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TwoToThePowerOfX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}