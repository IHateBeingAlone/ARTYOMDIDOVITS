using ARTYOMiNIKITIKUS.TwoArguments;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.TwoArguments
{
    [TestFixture]
    public class PlusRegularTests
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