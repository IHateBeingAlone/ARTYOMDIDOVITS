using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYOMiNIKITIKUS.Tests.OneArguments
{
    [TestFixture]
    public class LgXTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.3010)]
        [TestCase(3, 0.4771)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new LgX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}