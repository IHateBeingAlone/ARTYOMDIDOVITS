using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYOMiNIKITIKUS.Tests.TwoArguments
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(4, 7, 28)]
        [TestCase(5, 9, 45)]
        [TestCase(11, 11, 121)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}