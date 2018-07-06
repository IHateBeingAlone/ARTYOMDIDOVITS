using System;

namespace ARTYOMiNIKITIKUS.OneArgument
{
    public class XToThePowerOfTwo : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate function of the square of the number x
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> any positive number </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}