using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYOMiNIKITIKUS.Tests.TwoArguments
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(16, 2, 8)]
        [TestCase(30, 6, 5)]
        [TestCase(33, 6, 5.5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}