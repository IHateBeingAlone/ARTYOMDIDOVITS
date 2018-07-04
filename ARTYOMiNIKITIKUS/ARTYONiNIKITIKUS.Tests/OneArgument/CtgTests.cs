using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.OneArguments
{
    [TestFixture]
    public class CtgTests
    {
        [TestCase(1, 0.6421)]
        [TestCase(7, 1.1475)]
        [TestCase(12, -1.5727)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Ctg();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}