namespace ARTYOMiNIKITIKUS
{
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// interface for calculators of two arguments operations
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns> result in double </returns>
        double Calculate(double firstArgument, double secondArgument);
    }
}
