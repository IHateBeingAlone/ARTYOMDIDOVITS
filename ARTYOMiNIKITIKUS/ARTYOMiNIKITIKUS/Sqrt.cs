using System;

namespace ARTYOMiNIKITIKUS
{
    public class Sqrt : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}