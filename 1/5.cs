// печать только чётных значений из списка;

using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task5
    {
        private static void recursionIterator(List<int> array, int index)
        {
            if (index >= array.Count()) return;
            if (array[index] % 2 == 0) Console.WriteLine(array[index]);
            recursionIterator(array, index + 1);
        }
        public static void showEvenNumbers(List<int> array)
        {
            recursionIterator(array, 0);
        }
    }
}