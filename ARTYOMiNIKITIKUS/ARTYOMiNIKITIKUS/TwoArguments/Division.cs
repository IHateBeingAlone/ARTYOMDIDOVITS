using System;

namespace ARTYOMiNIKITIKUS
{
    public class Division: ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculate division function
        /// </summary>
        /// <param name="firstArgument"> any number </param>
        /// <param name="secondArgument"> any number, but zero is an exception </param>
        /// <returns> any number </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Error! Division by zero");
            }
            return firstArgument / secondArgument;
        }
    }
}