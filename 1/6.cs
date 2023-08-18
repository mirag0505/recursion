// печать элементов списка с чётными индексами;

using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task6
    {
        private static void recursionIterator(List<int> array, int index)
        {
            if (index >= array.Count()) return;
            if (index % 2 == 0) Console.WriteLine(array[index]);
            recursionIterator(array, index + 1);
        }
        public static void showValueByEvenIndex(List<int> array)
        {
            recursionIterator(array, 0);
        }
    }
}