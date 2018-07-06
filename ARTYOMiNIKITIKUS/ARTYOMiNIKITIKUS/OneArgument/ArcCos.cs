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
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Error! Does not fall into the range");
            }
            return Math.Acos(firstArgument);
        }
    }
}