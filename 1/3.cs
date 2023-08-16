// расчёт длины списка, для которого разрешена только операция удаления первого элемента pop(0) (и получение длины конечно);
using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task3
    {
        public static int getLengthList<T>(List<T> list, int length)
        {
            if (!list.Any()) return length;

            list.RemoveAt(0);
            return getLengthList<T>(list, length + 1);
        }
    }
}