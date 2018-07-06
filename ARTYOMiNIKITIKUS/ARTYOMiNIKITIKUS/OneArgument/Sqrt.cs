using System;

namespace ARTYOMiNIKITIKUS
{
    public class Sqrt : IOneArgumentCalculator
    {
        /// <summary>
        /// calculate sqrt function 
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap (0;+infinity) </param>
        /// <returns> result any positive number </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}