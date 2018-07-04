using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.TwoArguments
{
    [TestFixture]
    public class PlusTests
    {
        [TestCase(4, 7, 11)]
        [TestCase(5, 9, 14)]
        [TestCase(27, 51, 78)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Plus();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}