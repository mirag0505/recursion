// проверка, является ли строка палиндромом;

using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task4
    {
        public static bool isPalindrom(string text)
        {
            int midOfText = text.Length / 2;
            int start = 0;
            int end = text.Length - 1;

            if (start <= midOfText && end >= midOfText && text[start] != text[end]) return false;
            if (start == end || start > midOfText || end < midOfText) return true;
            return isPalindrom(text.Substring(start + 1, end - 1));
        }
    }
}