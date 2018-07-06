using ARTYOMiNIKITIKUS.TwoArguments;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.TwoArguments
{
   [TestFixture]
   public class MinusRegularTests
    {
        [Test]
        public void CalculateTest()
     {
          ITwoArgumentsCalculator calcultor = new Minus();
          double actual = calcultor.Calculate(6, 2);
          Assert.AreEqual(4, actual);
      }
   }

}