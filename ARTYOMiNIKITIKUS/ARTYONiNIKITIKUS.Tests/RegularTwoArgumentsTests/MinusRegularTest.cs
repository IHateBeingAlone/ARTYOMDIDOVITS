using ARTYOMiNIKITIKUS;
using NUnit.Framework;

namespace ARTYONiNIKITIKUS.Tests.SimpleTwoArgumentsTests
{
   [TestFixture]
   public class MinusTests
    {
        [Test]
        public void CalculateTest()
     {
           // подготовительные действия
          ITwoArgumentsCalculator calcultor = new Minus();
          double actual = calcultor.Calculate(6, 2);
          Assert.AreEqual(4, actual);
      }
   }

}