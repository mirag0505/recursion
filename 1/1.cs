// 1. возведение числа N в степень M;

using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task1
    {
        public static int MyPow(int number, int degree)
        {
            if (degree == 0) return 1;
            if (degree == 1) return number;
            return number * MyPow(number, degree - 1);
        }
    }
}