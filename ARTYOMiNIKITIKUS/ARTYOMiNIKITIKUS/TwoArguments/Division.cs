using System;

namespace ARTYOMiNIKITIKUS
{
    public class Division: ITwoArgumentsCalculator
    {
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