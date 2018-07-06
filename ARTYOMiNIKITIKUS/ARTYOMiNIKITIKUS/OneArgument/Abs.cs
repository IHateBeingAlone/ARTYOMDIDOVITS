using System;

namespace ARTYOMiNIKITIKUS
{
    public class Abs : IOneArgumentCalculator
    {
        /// <summary>
        /// function of a number module
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> a positive number </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}