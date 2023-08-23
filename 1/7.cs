// нахождение второго максимального числа в списке (с учётом, что максимальных может быть несколько, если они равны).
// Второе макс. -- это когда отсортировали список и берём второй элемент (отсчитывая с 1), если 5,4,3,2,5 например, то второе макс. должно получиться 5.
// Равенство или неравенство элементов значения не имеет, т.к. оно никак в условии не оговаривается.
// После того как вы отсортировали массив [2,5,4,3,5] по убыванию [5,5,4,3,2] берёте второй элемент 5, это и будет второе макс. Если массив [2,3,5,4],
// то второе макс будет 4, и т. д.

// Сортировка тут упоминается исключительно в плане понимания задачки, в самом решении её конечно быть не должно. Как минимум, в виде вызова стандартной
// сортировки не должно быть, а рекурсивно сортировку можете закодить, но правильное решение должно находить второе макс. за O(N) конечно.
// Если вдруг возникли сложности, сделайте для начала императивную версию, тут достаточно одного цикла (это элементарная задачка на моём курсе 
// с нуля для начинающих).

using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task7
    {
        static public int Compare<T>(T v1, T v2)
        {
            if (typeof(T) == typeof(String) || typeof(T) == typeof(Char))
            {
                return string.Compare(v1.ToString().Trim(), v2.ToString().Trim());
            }
            else
            {
                int newV1 = Convert.ToInt32(v1);
                int newV2 = Convert.ToInt32(v2);

                if (newV1 > newV2) return 1;
                if (newV1 < newV2) return -1;
                return 0;
            }
        }

        private static T recursionIterator<T>(List<T> array, int index, T max, T secondMax)
        {
            if (index >= array.Count()) return secondMax;

            var isMaxBigger = Compare(array[index], max) >= 0;
            var isSecondMaxBigger = Compare(array[index], secondMax) >= 0;

            if (isMaxBigger)
            {
                secondMax = max;
                max = array[index];
            }
            else if (isSecondMaxBigger) secondMax = array[index];

            return recursionIterator(array, index + 1, max, secondMax);
        }
        public static T getSecondMaxValue<T>(List<T> array)
        {
            return recursionIterator(array, 0, array[0], array[0]);
        }
    }
}

// найти максимальное значение
