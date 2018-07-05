﻿using System;

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
                case "ArcCos": return new ArcCos();
                case "ArcSin": return new ArcSin();
                case "ArcTg": return new ArcTg();
                case "ArcCtg": return new ArcCtg();
                case "LgX": return new LgX();
                case "LnX": return new LnX();
                case "XgradeTwo": return new XgradeTwo();
                case "TengradeX": return new TengradeX();
                case "TwogradeX": return new TwogradeX();

                default:
                    throw new Exception("error");
            }
        }
    }
}