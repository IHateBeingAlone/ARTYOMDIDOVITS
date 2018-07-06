using System;

namespace ARTYOMiNIKITIKUS
{
    public class Ctg : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate ctg function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return 1/Math.Tan(firstArgument);
        }
    }
}