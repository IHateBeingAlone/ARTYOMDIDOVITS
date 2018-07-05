using System;

namespace ARTYOMiNIKITIKUS
{
    public class LgX : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}