using System;

namespace ARTYOMiNIKITIKUS.OneArgument
{
    public class Abs : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate function of a number module
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result is a positive number </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}