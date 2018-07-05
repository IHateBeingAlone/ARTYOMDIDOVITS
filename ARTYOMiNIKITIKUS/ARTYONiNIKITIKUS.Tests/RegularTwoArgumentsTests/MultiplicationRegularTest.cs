using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.SimpleTwoArgumentsTests
{
    [TestFixture]
    public class MultiplicationTests
    {
    [Test]
    public void CalculateTest()
    {
        // подготовительные действия
        ITwoArgumentsCalculator calcultor = new Multiplication();
        double actual = calcultor.Calculate(6, 2);
        Assert.AreEqual(12, actual);
    }
    }

}