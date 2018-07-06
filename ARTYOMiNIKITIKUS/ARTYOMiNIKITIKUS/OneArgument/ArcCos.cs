using System;

namespace ARTYOMiNIKITIKUS.OneArgument
{
    public class ArcCos : IOneArgumentCalculator
    {
        /// <summary>
        /// arccos function 
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap[-1;1] </param>
        /// <returns> result in rads </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}