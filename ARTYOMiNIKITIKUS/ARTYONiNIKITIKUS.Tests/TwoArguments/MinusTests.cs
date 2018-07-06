using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYOMiNIKITIKUS.Tests.TwoArguments
{
    [TestFixture]
    public class MinusTests
    {
        [TestCase(12, 4, 8)]
        [TestCase(16, 10, 6)]
        [TestCase(84, 73, 11)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Minus();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}