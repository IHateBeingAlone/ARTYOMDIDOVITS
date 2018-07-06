using System;

namespace ARTYOMiNIKITIKUS.OneArgument
{
    public class TenToThePowerOfX : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate function of raising ten to the power of x
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> any positive number </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}