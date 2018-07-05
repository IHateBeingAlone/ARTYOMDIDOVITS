using System;

namespace ARTYOMiNIKITIKUS
{
    public class ngradeX : ITwoArgumentsCalculator
    {
            public double Calculate(double firstArgument, double secondArgument)
            {
                return Math.Pow(firstArgument, secondArgument);
            }
    }
}