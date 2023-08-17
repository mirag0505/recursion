// проверка, является ли строка палиндромом;

using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task4
    {
        private static bool recursionIterator(string text, int indexOffset)
        {
            int endIndex = text.Length - indexOffset - 1;
            int startIndex = indexOffset;

            if (startIndex >= endIndex) return true;
            if (text[startIndex] != text[endIndex]) return false;
            return recursionIterator(text, indexOffset + 1);
        }

        public static bool isPalindrom(string text)
        {
            return recursionIterator(text, 0);
        }
    }
}