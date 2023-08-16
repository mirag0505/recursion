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

            // я беру два значения по краям
            // если они равны, тогда я запускаю функцию по новойA
            // если они не равны, фо
            if (start == end || start > midOfText || end < midOfText) return true;
            if (text[start] == text[end]) return isPalindrom(text.Substring(++start, --end));
            else { return false; }


        }
    }
}