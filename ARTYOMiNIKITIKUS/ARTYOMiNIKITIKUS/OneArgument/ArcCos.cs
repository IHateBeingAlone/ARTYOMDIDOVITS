using System;

namespace ARTYOMiNIKITIKUS
{
    public class ArcCos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}