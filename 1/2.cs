// 2. вычисление суммы цифр числа;

using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task2
    {
        public static int SumOfNumber(int sum, int number)
        {
            // какой выход из рекурсии?
            // что будет изменять при каждой рекурсии
            if (number <= 0) return sum;
            return SumOfNumber(sum + number % 10, number / 10);
        }
    }
}