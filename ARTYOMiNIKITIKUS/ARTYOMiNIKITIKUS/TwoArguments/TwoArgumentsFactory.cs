using System;

namespace ARTYOMiNIKITIKUS.TwoArguments
{
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// fabrica for function of two variables
        /// </summary>
        /// <param name="calculatorName"> the definition of the function click </param>
        /// <returns> return incstanse of class </returns>
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Plus":
                    return new Plus();
                case "Minus":
                    return new Minus();
                case "Multiplication":
                    return new Multiplication();
                case "Division":
                    return new Division();
                case "NToThePowerOfX":
                    return new NToThePowerOfX();
                default:
                    throw new Exception("error");
            }
        }
    }
}