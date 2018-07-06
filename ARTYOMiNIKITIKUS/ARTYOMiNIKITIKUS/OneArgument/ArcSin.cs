using System;

namespace ARTYOMiNIKITIKUS.OneArgument
{
    public class ArcSin : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate arcsin function 
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap[-1;1] </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}