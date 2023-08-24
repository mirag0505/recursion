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
        static public int Compare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        private static T findSecondMaxRecursively<T>(List<T> array, int index, T max, T secondMax) where T : IComparable<T>
        {
            if (index >= array.Count()) return secondMax;

            if (Compare(array[index], max) >= 0)
            {
                secondMax = max;
                max = array[index];
            }
            else if (Compare(array[index], secondMax) >= 0) secondMax = array[index];

            return findSecondMaxRecursively(array, index + 1, max, secondMax);
        }

        public static T getSecondMaxValue<T>(List<T> array) where T : IComparable<T>
        {
            T max = default;
            T min = default;

            if (Compare(array[0], array[1]) >= 0)
            {
                max = array[0];
                min = array[1];
            }
            else
            {
                min = array[0];
                max = array[1];
            }

            int indexForStart = 2;
            return findSecondMaxRecursively(array, indexForStart, max, min);
        }
    }
}

// найти максимальное значение
