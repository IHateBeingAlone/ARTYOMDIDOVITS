using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.SimpleTwoArgumentsTests
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void CalculateTest()
        {
            // подготовительные действия
            ITwoArgumentsCalculator calcultor = new Division();
            double actual = calcultor.Calculate(6, 2);
            Assert.AreEqual(3, actual);
        }
    }

}