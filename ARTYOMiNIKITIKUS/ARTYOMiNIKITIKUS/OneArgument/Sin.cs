using System;

namespace ARTYOMiNIKITIKUS
{
    public class Sin: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}