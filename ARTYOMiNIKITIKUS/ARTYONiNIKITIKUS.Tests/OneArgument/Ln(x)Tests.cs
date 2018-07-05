using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYOMiNIKITIKUS.Tests.OneArguments
{
    [TestFixture]
    public class LnXTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.6932)]
        [TestCase(3, 1.0986)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new LnX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}