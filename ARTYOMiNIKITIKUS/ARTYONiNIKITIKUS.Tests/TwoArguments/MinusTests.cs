using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.TwoArguments
{
    [TestFixture]
    public class MinusTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Minus();();
            double actual = calculator.Calculate(5, 3);
            Assert.AreEqual(8, actual);
        }
    }
}