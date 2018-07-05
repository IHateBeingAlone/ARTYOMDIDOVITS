using System;

namespace ARTYOMiNIKITIKUS
{
    public class ArcSin : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}