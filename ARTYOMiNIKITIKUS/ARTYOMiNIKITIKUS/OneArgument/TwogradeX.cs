using System;

namespace ARTYOMiNIKITIKUS
{
    public class TwogradeX : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}