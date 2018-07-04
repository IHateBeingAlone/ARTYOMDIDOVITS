using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.OneArguments
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(16, 4)]
        [TestCase(900, 30)]
        [TestCase(121, 11)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Sqrt();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}