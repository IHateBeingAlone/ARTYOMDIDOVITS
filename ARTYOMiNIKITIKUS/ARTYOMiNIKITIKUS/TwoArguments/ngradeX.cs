using System;

namespace ARTYOMiNIKITIKUS
{
    public class ngradeX : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculate function of raising ten to the power of x
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <param name="secondArgument"> any number </param>
        /// <returns> any number </returns>
        public double Calculate(double firstArgument, double secondArgument)
            {
                return Math.Pow(firstArgument, secondArgument);
            }
    }
}