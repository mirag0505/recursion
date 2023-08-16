using System.Collections.Generic;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Task1()
    {
        Assert.Equal(1, Recursion.Task1.MyPow(1, 1));
        Assert.Equal(1, Recursion.Task1.MyPow(1, 0));
        Assert.Equal(1, Recursion.Task1.MyPow(3, 0));

        Assert.Equal(4, Recursion.Task1.MyPow(2, 2));
        Assert.Equal(8, Recursion.Task1.MyPow(2, 3));
        Assert.Equal(16, Recursion.Task1.MyPow(2, 4));


        Assert.Equal(9, Recursion.Task1.MyPow(3, 2));
        Assert.Equal(27, Recursion.Task1.MyPow(3, 3));
        Assert.Equal(81, Recursion.Task1.MyPow(3, 4));
    }

    [Fact]
    public void Task2()
    {
        Assert.Equal(1, Recursion.Task2.SumOfNumber(0, 1));
        Assert.Equal(2, Recursion.Task2.SumOfNumber(0, 11));
        Assert.Equal(3, Recursion.Task2.SumOfNumber(0, 111));

        Assert.Equal(4, Recursion.Task2.SumOfNumber(0, 22));
        Assert.Equal(6, Recursion.Task2.SumOfNumber(0, 222));

        Assert.Equal(6, Recursion.Task2.SumOfNumber(0, 123));
        Assert.Equal(0, Recursion.Task2.SumOfNumber(0, 000));
    }

    [Fact]
    public void Task3()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(5, Recursion.Task3.getLengthList(list, 0));

        List<int> list1 = new List<int> { };
        Assert.Equal(0, Recursion.Task3.getLengthList(list1, 0));

        List<int> list2 = new List<int> { 123, 123, 1231, 0, 123 };
        Assert.Equal(5, Recursion.Task3.getLengthList(list2, 0));
    }


    [Fact]
    public void Task4()
    {
        Assert.Equal(true, Recursion.Task4.isPalindrom("12321", 0));
        Assert.Equal(true, Recursion.Task4.isPalindrom("1221", 0));
        Assert.Equal(true, Recursion.Task4.isPalindrom("aba", 0));

        Assert.Equal(false, Recursion.Task4.isPalindrom("1234", 0));
        Assert.Equal(false, Recursion.Task4.isPalindrom("4321", 0));

        Assert.Equal(false, Recursion.Task4.isPalindrom("1231", 0));
        Assert.Equal(false, Recursion.Task4.isPalindrom("13321", 0));
    }
}