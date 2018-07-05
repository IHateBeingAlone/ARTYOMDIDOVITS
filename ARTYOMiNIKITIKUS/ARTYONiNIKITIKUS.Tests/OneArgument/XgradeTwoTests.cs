using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYOMiNIKITIKUS.Tests.OneArguments
{
    [TestFixture]
    public class XgradeTwoTests
    {
        [TestCase(2, 4)]
        [TestCase(3, 9)]
        [TestCase(4, 16)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new XgradeTwo();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}