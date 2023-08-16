// проверка, является ли строка палиндромом;

using System;
using System.Collections.Generic;

namespace Recursion
{
    public class Task4
    {
        public static bool isPalindrom(string text, int indexOffset)
        {
            int midOfText = text.Length / 2;
            int endIndex = text.Length - indexOffset - 1;

            if (indexOffset <= midOfText && endIndex >= midOfText && text[indexOffset] != text[endIndex]) return false;
            if (indexOffset == endIndex || indexOffset > midOfText || endIndex < midOfText) return true;
            return isPalindrom(text, indexOffset + 1);
        }
    }
}