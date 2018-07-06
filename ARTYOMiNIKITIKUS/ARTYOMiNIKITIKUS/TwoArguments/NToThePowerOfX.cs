using System;

namespace ARTYOMiNIKITIKUS.TwoArguments
{
    public class NToThePowerOfX : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculate function of raising N to the power of x
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