using System;

namespace ARTYOMiNIKITIKUS.OneArgument
{
    public class LnX: IOneArgumentCalculator
    {
        /// <summary>
        /// calculate of the natural logarithm
        /// </summary>
        /// <param name="firstArgument"> the number lying in the gap[0;+infinity) </param>
        /// <returns> result any number </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}