using System;

namespace ARTYOMiNIKITIKUS
{
    public class LnX: IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}