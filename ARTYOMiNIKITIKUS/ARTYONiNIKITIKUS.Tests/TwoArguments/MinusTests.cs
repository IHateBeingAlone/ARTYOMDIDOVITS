using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.TwoArguments
{
    [TestFixture]
    public class MinusTests
    {
        [TestCase(8, 4, 4)]
        [TestCase(16, 7, 9)]
        [TestCase(84, 51, 33)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Minus();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}