using System;

namespace MaxNumberLib
{
    public static class MaxNumberFinder
    {
        public static T Max<T>(T num1, T num2) where T : IComparable<T>
        {
            return num1.CompareTo(num2) >= 0 ? num1 : num2;
        }

        public static T Max<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            return Max(Max(num1, num2), num3);
        }
    }
}
