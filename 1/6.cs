// печать элементов списка с чётными индексами;

using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task6
    {
        private static void recursionIterator<T>(List<T> array, int index)
        {
            if (index >= array.Count()) return;
            Console.WriteLine(array[index]);
            recursionIterator(array, index + 2);
        }
        public static void showValueByEvenIndex<T>(List<T> array)
        {
            recursionIterator(array, 0);
        }
    }
}