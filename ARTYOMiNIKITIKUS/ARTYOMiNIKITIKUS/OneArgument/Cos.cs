using System;

namespace ARTYOMiNIKITIKUS
{
    public class Cos: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }   
}