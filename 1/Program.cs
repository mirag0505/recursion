using Recursion;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };

        var result = Recursion.Task3.getLengthList(list, 0);
    }
}