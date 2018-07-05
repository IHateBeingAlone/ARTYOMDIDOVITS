using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYOMiNIKITIKUS.Tests.OneArguments
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 0.5403)]
        [TestCase(7, 0.7540)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Cos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}