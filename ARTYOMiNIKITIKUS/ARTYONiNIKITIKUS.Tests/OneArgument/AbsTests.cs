using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYOMiNIKITIKUS.Tests.OneArguments
{
    [TestFixture]
    public class AbsTests
    {
        [TestCase(-6, 6)]
        [TestCase(98, 98)]
        [TestCase(-144, 144)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Abs();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}