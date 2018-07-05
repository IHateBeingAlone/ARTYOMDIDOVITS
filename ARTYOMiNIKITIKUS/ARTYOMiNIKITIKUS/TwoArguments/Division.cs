using System;

namespace ARTYOMiNIKITIKUS
{
    public class Division: ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("OSHIPKA! NE DELI NA NOL', DOLBOEB");
            }
            return firstArgument / secondArgument;
        }
    }
}