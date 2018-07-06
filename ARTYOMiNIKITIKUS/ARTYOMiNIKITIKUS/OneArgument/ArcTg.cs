using System;

namespace ARTYOMiNIKITIKUS.OneArgument
{
    public class ArcTg : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate arctg function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}