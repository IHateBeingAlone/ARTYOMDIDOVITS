using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.SimpleTwoArgumentsTests
{
    [TestFixture]
    public class PlusTests
    {
        [Test]
        public void CalculateTest()
        {
            // подготовительные действия
            ITwoArgumentsCalculator calcultor = new Plus();
            double actual = calcultor.Calculate(6, 2);
            Assert.AreEqual(8, actual);
        }
    }

}