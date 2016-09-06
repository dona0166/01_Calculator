using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
           return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Sum(int[] numbers)
        {
            numbers = new int[2];
            return numbers[0] + numbers[1];
        }
    }
}