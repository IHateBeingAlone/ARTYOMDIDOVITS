using System;

namespace ARTYOMiNIKITIKUS.OneArgument
{
    public class ArcCtg : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate arcctg function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return 1/Math.Atan(firstArgument);
        }
    }
}