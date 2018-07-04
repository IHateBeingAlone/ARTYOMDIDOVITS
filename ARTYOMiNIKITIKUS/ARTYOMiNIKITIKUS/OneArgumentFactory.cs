using System;

namespace ARTYOMiNIKITIKUS
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin": return new Sin();
                case "Cos": return new Cos();
                case "Tg": return new Tg();
                case "Ctg": return new Ctg();
                case "Sqrt": return new Sqrt();
                case "Abs": return new Abs();

                default:
                    throw new Exception("error");
            }
        }
    }
}